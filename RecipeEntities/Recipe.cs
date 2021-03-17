using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEntities
{
    public class Recipe
    {
        public int CategoryId { get; set; }
        public string RecipeName { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}
