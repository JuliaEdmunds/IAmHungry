using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IAmHungry
{
    public class IngredientsWrapper
    {
        public List<IngredientInformation> Ingredients { get; set; }
    }

    public class IngredientInformation
    {
        public string IngredientName { get; set; }

        public List<EViolations> Violates { get; set; }

        public override string ToString()
        {
            return IngredientName;
        }
    }
}
