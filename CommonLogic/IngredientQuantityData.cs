using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IAmHungry
{
    public class IngredientQuantityData
    {
        public string Name { get; set; }
        public string Amount { get; set; }

        [JsonIgnore]
        public IngredientInformation AssociatedIngredient;

        public override string ToString()
        {
            return $"{Amount} {Name}";
        }
    }
}
