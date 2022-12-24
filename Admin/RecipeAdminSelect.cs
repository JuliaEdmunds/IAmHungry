using IAmHungry;
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

namespace Admin
{
    public partial class RecipeAdminSelect : Form
    {
        public string CurrentRecipeFileName;
        public List<Recipe> AllRecipeList = RecipeDataBase.AllRecipeList;

        public RecipeAdminSelect()
        {
            InitializeComponent();
        }

        private void RecipeAdminSelect_Load(object sender, EventArgs e)
        {
            foreach (Recipe recipe in AllRecipeList)
            {
                CurrentRecipeFileName = recipe.FileName;
                cboChooseRecipe.Items.Add(CurrentRecipeFileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RecipeAdminPanel recipeAdminPanel = new RecipeAdminPanel(CurrentRecipeFileName);
            recipeAdminPanel.ShowDialog();

            this.Close();
        }

        private void cboChooseRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;

            CurrentRecipeFileName = cboChooseRecipe.SelectedItem.ToString();
        }

        private void txtNewRecipeName_TextChanged(object sender, EventArgs e)
        {
            btnAddRecipe.Enabled = true;
            CurrentRecipeFileName = txtNewRecipeName.Text;
        }

        // TODO: Update to create new recipe - not working - new recipe is not visible/readible
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string templateFilePath = $"C:\\Users\\julia\\Desktop\\Personal Projects\\IAmHungry\\Data\\Recipes\\Template Recipe.json";
            Recipe newRecipe = new Recipe();
            newRecipe.FileName = CurrentRecipeFileName;

            string newFilePath = $"C:\\Users\\julia\\Desktop\\Personal Projects\\IAmHungry\\Data\\Recipes\\{CurrentRecipeFileName}.json";
            
            File.Copy(templateFilePath, newFilePath);
            AllRecipeList.Add(newRecipe);

            RecipeAdminPanel recipeAdminPanel = new RecipeAdminPanel(CurrentRecipeFileName);
            recipeAdminPanel.ShowDialog();

            this.Close();
        }

      
    }
}
