using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmHungry
{
    public class RecipeRequestData
    {
        public string Ingredient1;
        public string Ingredient2;
        public string Ingredient3;
        public List<EViolations> Violations;
        EMealType? MealType;
        ETaste? TasteSelected;

        public RecipeRequestData(string ingredient1, string ingredient2, string ingredient3, List<EViolations> violations, EMealType? mealType, ETaste? tasteSelected)
        {
            Ingredient1 = ingredient1;
            Ingredient2 = ingredient2;
            Ingredient3 = ingredient3;
            Violations = violations;
            MealType = mealType;
            TasteSelected = tasteSelected;
        }

        public bool IsValidForRecipe(Recipe recipe)
        {
            List<IngredientQuantityData> currentIngredients = recipe.Ingredients;
            bool ingredientMatch = IsIngredientsValid(currentIngredients);

            bool dietMatch = IsDietValid(currentIngredients);

            EMealType currentMealType = recipe.MealType;
            bool typeMatch = IsMealTypeValid(currentMealType);

            List <ETaste> currentTastes = recipe.TasteTags;
            bool tasteMatch = IsTasteValid(currentTastes);

            return ingredientMatch && dietMatch && typeMatch && tasteMatch;
        }

        private bool IsIngredientsValid(List<IngredientQuantityData> currentIngredients)
        {
            bool match = false;
            for (int i = 0; i < currentIngredients.Count; i++)
            {
                IngredientQuantityData ingredientQuantityData = currentIngredients[i];
                string currentIngredientName = ingredientQuantityData.Name;

                if (Ingredient1 == currentIngredientName || Ingredient2 == currentIngredientName || Ingredient3 == currentIngredientName)
                {
                    match = true;
                }
            }
            return match;
        }

        private bool IsDietValid(List<IngredientQuantityData> currentIngredients)
        {
            for (int i = 0; i < currentIngredients.Count; i++)
            {
                IngredientQuantityData ingredientQuantityData = currentIngredients[i];
                string currentIngredientName = ingredientQuantityData.Name;

                IngredientInformation associatedIngredient = ingredientQuantityData.AssociatedIngredient;
                for (int j = 0; j < Violations.Count; j++)
                {
                    EViolations currentViolation = Violations[j];

                    if (associatedIngredient.Violates.Contains(currentViolation))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsMealTypeValid(EMealType currentMealType)
        {
            if (!MealType.HasValue || currentMealType == MealType)
            {
                return true;
            }
            return false;
        }

        private bool IsTasteValid(List<ETaste> currentTastes)
        {
            if (!TasteSelected.HasValue)
            {
                return true;
            }

            for (int l = 0; l < currentTastes.Count; l++)
            {
                ETaste currentTaste = currentTastes[l];
                if (currentTaste == TasteSelected)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
