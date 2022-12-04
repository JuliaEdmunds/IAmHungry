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

namespace Admin
{
    public partial class RecipeAdminPanel : Form
    {
        public string CurrentRecipeFileName;

        private Recipe m_CurrentRecipe;

        public RecipeAdminPanel()
        {
            InitializeComponent();
        }

        private void RecipeAdminPanel_Load(object sender, EventArgs e)
        {
            CurrentRecipeFileName = "Test Dummy";

            // Find recipe with matching name from RecipeDatabase
            m_CurrentRecipe = RecipeDataBase.FindRecipeWithFileName(CurrentRecipeFileName);

            // Setup all text fields according to current values in m_CurrentRecipe
            txtRecipeName.Text = m_CurrentRecipe.Name;
            txtFileName.Text = m_CurrentRecipe.FileName;

            // Load current ingredients as UI input (creating txt for each of the existing ingredients) - editable
            List<IngredientQuantityData> currentIngredients = m_CurrentRecipe.Ingredients;
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

                btnDeleteIngredient.Click += (_, __) => { BtnDeleteIngredient_Click(btnDeleteIngredient, lblName, txtIngredientName, lblAmount, txtIngredientAmount, currentIngredient); };
            }
        }

        // TODO: Be able to remove ingredients (dynamically add a delete button for each ingredient - remove UI & data)

        // TODO: Add remaining fields to fill in for the Recipe

        // Check if there's no conflict between lower/CamelCase ETaste/ETypes

        private void txtFileName_TextChanged(object sender, EventArgs e)
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
            this.Close();
        }

        private string GetFilePath(string fileName)
        {
            return $"C:\\Users\\julia\\Desktop\\Personal Projects\\IAmHungry\\Data\\Recipes\\{CurrentRecipeFileName}.json";
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            IngredientQuantityData ingredientQuantityData = new IngredientQuantityData();
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
    }
}
