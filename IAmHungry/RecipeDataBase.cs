using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IAmHungry
{
    public static class RecipeDataBase
    {
        public static List<IngredientInformation> IngredientInformations = new List<IngredientInformation>();

        public static HashSet<string> KnownIngredientNames = new HashSet<string>();

        public static List<Recipe> ValidRecipes = new List<Recipe>();

        public static List<Recipe> AllRecipeList = new List<Recipe>();

        public static Recipe CurrentRecipe;

        static RecipeDataBase()
        {
            LoadIngredients();
            LoadAllRecipes();

            for (int i = 0; i < AllRecipeList.Count; i++)
            {
                List<IngredientQuantityData> currentIngredients = AllRecipeList[i].Ingredients;
                for (int j = 0; j < currentIngredients.Count; j++)
                {
                    IngredientQuantityData currentIngredient = currentIngredients[j];
                    KnownIngredientNames.Add(currentIngredient.Name);
                }
            }
        }

        private static void LoadIngredients()
        {
            string ingredientsFile = File.ReadAllText("C:\\Users\\julia\\Desktop\\Personal Projects\\IAmHungry\\Data\\Ingredients.json");
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    },
            };

            IngredientsWrapper wrapper = JsonSerializer.Deserialize<IngredientsWrapper>(ingredientsFile, options);
            IngredientInformations.AddRange(wrapper.Ingredients);
        }

        private static void LoadAllRecipes()
        {
            string[] fileNames = Directory.GetFiles("C:\\Users\\julia\\Desktop\\Personal Projects\\IAmHungry\\Data\\Recipes");
            for (int i = 0; i < fileNames.Length; i++)
            {
                string currentFileName = fileNames[i];
                string json = File.ReadAllText(currentFileName);

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    },
                };

                Recipe currentRecipe = JsonSerializer.Deserialize<Recipe>(json, options);
                List<IngredientQuantityData> currentIngredients = currentRecipe.Ingredients;

                // finds associated Ingredient for each ingredientdata in recipe

                for (int j = 0; j < currentIngredients.Count; j++)
                {
                    IngredientQuantityData currentIngredient = currentIngredients[j];
                    string currentIngredientName = currentIngredient.Name;
                    currentIngredient.AssociatedIngredient = FindAssociatedIngredient(currentIngredientName);
                }

                AllRecipeList.Add(currentRecipe);
            }
        }

        public static IngredientInformation FindAssociatedIngredient(string ingredientName)
        {
            for (int i = 0; i < IngredientInformations.Count; i++)
            {
                IngredientInformation ingredientInformation = IngredientInformations[i];
                string ingredientInfoName = ingredientInformation.IngredientName;

                if (ingredientName == ingredientInfoName)
                {
                    return ingredientInformation;
                }
            }
            Console.Error.WriteLine($"{ingredientName} is not in the Ingredients");
            return null;
        }

        public static void FindValidRecipes(RecipeRequestData recipeRequestData)
        {
            ValidRecipes.Clear();

            for (int i = 0; i < AllRecipeList.Count; i++)
            {
                Recipe currentRecipe = AllRecipeList[i];

                if (recipeRequestData.IsValidForRecipe(currentRecipe))
                {
                    ValidRecipes.Add(currentRecipe);
                }
            }
        }

        public static Recipe GetRandomValidRecipe()
        {
            if (ValidRecipes.Count == 0)
            {
                return null;
            }
            if (ValidRecipes.Count == 1)
            {
                return ValidRecipes[0];
            }

            Random rnd = new Random();
            int randomRecipeIndex;
            do
            {
                randomRecipeIndex = rnd.Next(ValidRecipes.Count);
            }
            while (ValidRecipes[randomRecipeIndex] == CurrentRecipe);

            return ValidRecipes[randomRecipeIndex];
        }
    }
}
