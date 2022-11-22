using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAmHungry
{
    public partial class RecipeForm : Form
    {
        public RecipeForm()
        {
            InitializeComponent();
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            lblIngredientList.Text = string.Empty;
            string recipeName = RecipeDataBase.CurrentRecipe.Name;
            lblRecipeName.Text = recipeName;
            List<IngredientQuantityData> currentIngredients = RecipeDataBase.CurrentRecipe.Ingredients;
            string bullet = "\t\u2022";
            for (int i = 0; i < currentIngredients.Count; i++)
            {
                IngredientQuantityData currentData = currentIngredients[i];
                string textToPrint = $"{bullet} {currentData.Amount} {currentData.Name.ToLower()}\n";
                lblIngredientList.Text += textToPrint;
            }
        }

        private void btbChangeSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeepSearching_Click(object sender, EventArgs e)
        {
            RecipeDataBase.CurrentRecipe = RecipeDataBase.GetRandomValidRecipe();
            Reset();
        }
    }
}
