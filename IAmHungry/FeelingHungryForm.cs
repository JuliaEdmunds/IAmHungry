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
    public partial class FeelingHungryForm : Form
    {
        public FeelingHungryForm()
        {
            InitializeComponent();
        }


        private void FeelingHungryForm_Load(object sender, EventArgs e)
        {
            string[] tasteNames = Enum.GetNames(typeof(ETaste));
            for (int i = 0; i < tasteNames.Length; i++)
            {
                cboTaste.Items.Add(tasteNames[i]);
            }

            string[] typeNames = Enum.GetNames(typeof(EMealType));
            for (int i = 0; i < typeNames.Length; i++)
            {
                cboMealType.Items.Add(typeNames[i]);
            }

            string[] ingredients = RecipeDataBase.KnownIngredientNames.ToArray();
            cboIngredient1.Items.AddRange(ingredients);
            cboIngredient2.Items.Add("");
            cboIngredient2.Items.AddRange(ingredients);
            cboIngredient3.Items.Add("");
            cboIngredient3.Items.AddRange(ingredients);
        }

        private void btnFindRecipes_Click(object sender, EventArgs e)
        {
            string ingredient1 = GetSelectedIngredient(cboIngredient1);
            string ingredient2 = GetSelectedIngredient(cboIngredient2);
            string ingredient3 = GetSelectedIngredient(cboIngredient3);

            List<EViolations> dietaryRequirements = new List<EViolations>();

            if (chkGlutenFree.Checked)
            {
                dietaryRequirements.Add(EViolations.GlutenFree);
            }
            if (chkLactoseFree.Checked)
            {
                dietaryRequirements.Add(EViolations.LactoseFree);
            }
            if (chkPeanutsFree.Checked)
            {
                dietaryRequirements.Add(EViolations.PeanutsFree);
            }
            if (chkPescatarian.Checked)
            {
                dietaryRequirements.Add(EViolations.Pescatarian);
            }
            if (chkVegan.Checked)
            {
                dietaryRequirements.Add(EViolations.Vegan);
            }
            if (chkVegetarian.Checked)
            {
                dietaryRequirements.Add(EViolations.Vegetarian);
            }

            EMealType? mealType = null;
            if (cboMealType.SelectedIndex > 0)
            {
                string mealTypeAsString = cboMealType.Items[cboMealType.SelectedIndex].ToString();
                mealType = (EMealType)Enum.Parse(typeof(EMealType), mealTypeAsString, true);
            }

            ETaste? tasteSelected = null;
            if (cboTaste.SelectedIndex > 0)
            {
                string tasteAsString = cboTaste.Items[cboTaste.SelectedIndex].ToString();
                tasteSelected = (ETaste)Enum.Parse(typeof(ETaste), tasteAsString, true);
            }

            RecipeRequestData recipeRequestData = new RecipeRequestData(ingredient1, ingredient2, ingredient3, dietaryRequirements, mealType, tasteSelected);

            RecipeDataBase.FindValidRecipes(recipeRequestData);
            RecipeDataBase.CurrentRecipe = RecipeDataBase.GetRandomValidRecipe();
            if (RecipeDataBase.CurrentRecipe == null)
            {
                MessageBox.Show("I can't find recipes matching your criteria");
            }
            else
            {
                RecipeForm recipeForm = new RecipeForm();
                recipeForm.ShowDialog();
            }     
        }

        private string GetSelectedIngredient(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex < 0)
            {
                return null;
            }
            return comboBox.Items[comboBox.SelectedIndex].ToString();
        }
    }
}
