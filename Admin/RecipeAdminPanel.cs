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
        }

        // TODO: Load current ingredients as UI input (creating txt for each of the existing ingredients) - editable

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

            txtIngredientName.TextChanged += (_, __) => { TxtIngredientName_TextChanged(txtIngredientName, ingredientQuantityData); };
            txtIngredientAmount.TextChanged += (_, __) => { TxtIngredientAmount_TextChanged(txtIngredientAmount, ingredientQuantityData); };

            flwIngredients.Controls.Add(lblName);
            flwIngredients.Controls.Add(txtIngredientName);

            flwIngredients.Controls.Add(lblAmount);
            flwIngredients.Controls.Add(txtIngredientAmount);
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
