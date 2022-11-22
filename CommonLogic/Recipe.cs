using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmHungry
{ 
    public class Recipe
    {
        public string Name { get; set; }
        public List<IngredientQuantityData> Ingredients { get; set; }

        public EMealType MealType { get; set; }

        public List<ETaste> TasteTags { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
