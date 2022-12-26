using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using IAmHungry;
using System.Xml.Linq;


// TODO: Add recipe instruction

// TODO: Change the file name - stretch goal

// TODO: Add way of editing ingredients (it has to have its own admin panel) - very similar to the current one - stretch goal

namespace Admin
{
    public partial class RecipeAdminPanel : Form
    {
        public string CurrentRecipeFileName;

        private Recipe m_CurrentRecipe;

        public RecipeAdminPanel(string currentRecipeFileName)
        {
            InitializeComponent();
            CurrentRecipeFileName = currentRecipeFileName;
        }

        private void RecipeAdminPanel_Load(object sender, EventArgs e)
        {
            // Find recipe with matching name from RecipeDatabase
            m_CurrentRecipe = RecipeDataBase.FindRecipeWithFileName(CurrentRecipeFileName);

            // Setup all text fields according to current values in m_CurrentRecipe
            txtRecipeName.Text = m_CurrentRecipe.Name;
            lblFileNameText.Text = m_CurrentRecipe.FileName;
            txtUrl.Text = m_CurrentRecipe.Url;

            string[] typeNames = Enum.GetNames(typeof(EMealType));
            for (int i = 0; i < typeNames.Length; i++)
            {
                cboMealType.Items.Add(typeNames[i]);
            }
            cboMealType.Text = m_CurrentRecipe.MealType.ToString();

            // Add all possible taste tags and check the taste tags currently set in the recipe
            string[] tasteNames = Enum.GetNames(typeof(ETaste));
            List<ETaste> currentTasteTags = m_CurrentRecipe.TasteTags;
            for (int i = 0; i < tasteNames.Length; i++)
            {
                string currentTasteString = tasteNames[i];
                clbTaste.Items.Add(currentTasteString);
                ETaste currentTaste;
                Enum.TryParse(currentTasteString, out currentTaste);

                if (currentTasteTags != null)
                {
                    for (int j = 0; j < currentTasteTags.Count; j++)
                    {
                        ETaste currentTasteInRecipe = currentTasteTags[j];
                        if (currentTaste == currentTasteInRecipe)
                        {
                            clbTaste.SetItemChecked(i, true);
                        }
                    }
                }
            }

            // Load current ingredients as UI input (creating txt for each of the existing ingredients) - editable
            List<IngredientQuantityData> currentIngredients = m_CurrentRecipe.Ingredients;

            if (currentIngredients != null)
            {
                for (int i = 0; i < currentIngredients.Count; i++)
                {
                    IngredientQuantityData currentIngredient = currentIngredients[i];

                    TextBox txtIngredientName = new TextBox();
                    Label lblName = new Label();
                    lblName.Text = "Name";
                    txtIngredientName.Text = currentIngredient.Name;

                    TextBox txtIngredientAmount = new TextBox();
                    Label lblAmount = new Label();
                    lblAmount.Text = "Amount";
                    txtIngredientAmount.Text = currentIngredient.Amount;

                    Button btnDeleteIngredient = new Button();
                    btnDeleteIngredient.Text = "Delete";

                    flwIngredients.Controls.Add(lblName);
                    flwIngredients.Controls.Add(txtIngredientName);

                    flwIngredients.Controls.Add(lblAmount);
                    flwIngredients.Controls.Add(txtIngredientAmount);

                    flwIngredients.Controls.Add(btnDeleteIngredient);

                    txtIngredientName.TextChanged += (_, __) => { TxtIngredientName_TextChanged(txtIngredientName, currentIngredient); };
                    txtIngredientAmount.TextChanged += (_, __) => { TxtIngredientAmount_TextChanged(txtIngredientAmount, currentIngredient); };

                    // Remove ingredients (dynamically add a delete button for each ingredient - remove UI & data)
                    btnDeleteIngredient.Click += (_, __) => { BtnDeleteIngredient_Click(btnDeleteIngredient, lblName, txtIngredientName, lblAmount, txtIngredientAmount, currentIngredient); };
                }
            }

            // Load current instructions 
            string[] currentInstructions = m_CurrentRecipe.Instructions;
            string bullet = "\t\u2022";
            for (int i = 0; i < currentInstructions.Length; i++)
            {
                string currentLine = currentInstructions[i];
                string textToPrint = $"{bullet} {currentLine}\r\n";
                txtInstructions.Text += textToPrint;
            }
        }

        private void txtRecipeName_TextChanged(object sender, EventArgs e)
        {
            m_CurrentRecipe.Name = txtRecipeName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    },

                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(m_CurrentRecipe, options);
            string filePath = GetFilePath(CurrentRecipeFileName);
            File.WriteAllText(filePath, jsonString);

            this.Dispose();

            RecipeAdminSelect recipeAdminSelect = new RecipeAdminSelect();
            recipeAdminSelect.ShowDialog();
        }

        private string GetFilePath(string fileName)
        {
            return $"C:\\Users\\julia\\Desktop\\Personal Projects\\IAmHungry\\Data\\Recipes\\{CurrentRecipeFileName}.json";
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            IngredientQuantityData ingredientQuantityData = new IngredientQuantityData();

            if (m_CurrentRecipe.Ingredients == null )
            {
                m_CurrentRecipe.Ingredients = new List<IngredientQuantityData>();
            }

            m_CurrentRecipe.Ingredients.Add(ingredientQuantityData);

            TextBox txtIngredientAmount = new TextBox();
            Label lblAmount = new Label();
            lblAmount.Text = "Amount";
            TextBox txtIngredientName = new TextBox();
            Label lblName = new Label();
            lblName.Text = "Name";

            Button btnDeleteIngredient = new Button();
            btnDeleteIngredient.Text = "Delete";

            txtIngredientName.TextChanged += (_, __) => { TxtIngredientName_TextChanged(txtIngredientName, ingredientQuantityData); };
            txtIngredientAmount.TextChanged += (_, __) => { TxtIngredientAmount_TextChanged(txtIngredientAmount, ingredientQuantityData); };

            flwIngredients.Controls.Add(lblName);
            flwIngredients.Controls.Add(txtIngredientName);

            flwIngredients.Controls.Add(lblAmount);
            flwIngredients.Controls.Add(txtIngredientAmount);

            flwIngredients.Controls.Add(btnDeleteIngredient);

            // Remove ingredients (dynamically add a delete button for each ingredient - remove UI & data)
            btnDeleteIngredient.Click += (_, __) => { BtnDeleteIngredient_Click(btnDeleteIngredient, lblName, txtIngredientName, lblAmount, txtIngredientAmount, ingredientQuantityData); };
        }

        private void BtnDeleteIngredient_Click(Button btnDeleteIngredient, Label lblName, TextBox textBoxName, Label lblAmount, TextBox textBoxAmount, IngredientQuantityData ingredientQuantityData)
        {
            m_CurrentRecipe.Ingredients.Remove(ingredientQuantityData);

            flwIngredients.Controls.Remove(lblName);
            flwIngredients.Controls.Remove(textBoxName);

            flwIngredients.Controls.Remove(lblAmount);
            flwIngredients.Controls.Remove(textBoxAmount);

            flwIngredients.Controls.Remove(btnDeleteIngredient);
        }

        private void TxtIngredientAmount_TextChanged(TextBox textBox, IngredientQuantityData ingredientQuantityData)
        {
            ingredientQuantityData.Amount = textBox.Text;
        }

        private void TxtIngredientName_TextChanged(TextBox textBox, IngredientQuantityData ingredientQuantityData)
        {
            ingredientQuantityData.Name = textBox.Text;
        }

        private void cboMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mealTypeAsString = cboMealType.Items[cboMealType.SelectedIndex].ToString();
            m_CurrentRecipe.MealType = (EMealType)Enum.Parse(typeof(EMealType), mealTypeAsString, true);
        }

        private void clbTaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_CurrentRecipe.TasteTags == null)
            {
                m_CurrentRecipe.TasteTags = new List<ETaste>();
            }

            m_CurrentRecipe.TasteTags.Clear();

            for (int i = 0; i < clbTaste.CheckedItems.Count; i++)
            {
                string tasteTagAsString = (string)clbTaste.CheckedItems[i];
                m_CurrentRecipe.TasteTags.Add((ETaste)Enum.Parse(typeof(ETaste), tasteTagAsString, true));
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            m_CurrentRecipe.Url = txtUrl.Text;
        }

        private void txtInstructions_TextChanged(object sender, EventArgs e)
        {
            string[] stringSeparators = new string[] { "\r\n" };
            string textToSave = txtInstructions.Text;
            string[] fullTextToSave = textToSave.Split(stringSeparators, StringSplitOptions.None);
            m_CurrentRecipe.Instructions = fullTextToSave;
        }
    }
}
