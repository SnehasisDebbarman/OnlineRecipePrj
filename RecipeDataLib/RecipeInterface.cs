using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeEntities;

namespace RecipeDataLib
{
    interface RecipeInterface
    {
        List<RecipeEntities.Recipe> GetAllRecipes();
        List<RecipeEntities.Recipe> GetRecipesById(int id);
    }
}
