using IAmHungry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class RecipeAdminSelect : Form
    {
        public string CurrentRecipeFileName;

        public RecipeAdminSelect()
        {
            InitializeComponent();
        }

        private void RecipeAdminSelect_Load(object sender, EventArgs e)
        {
            List<Recipe> AllRecipeList = RecipeDataBase.AllRecipeList;
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
    }
}
