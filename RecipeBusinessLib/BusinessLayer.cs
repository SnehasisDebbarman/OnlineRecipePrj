using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeEntities;
using RecipeDataLib;

namespace RecipeBusinessLib
{
    public class BusinessLayer
    {
        public List<Recipe> GetAllRes()
        {
            List<Recipe> lstRes = new List<Recipe>();
            // AdoConnected dal = new AdoConnected();
            AdoConnected dal = new AdoConnected();
            lstRes = dal.GetAllRecipes();
            return lstRes;
        }
        public List<Recipe> GetResById(int id)
        {
            List<Recipe> lstRes = new List<Recipe>();
            // AdoConnected dal = new AdoConnected();
            AdoConnected dal = new AdoConnected();
            lstRes = dal.GetRecipesById(id);
            return lstRes;
        }
        public List<Category> GetAllCtas()
        {
            List<Category> lstCats = new List<Category>();
            // AdoConnected dal = new AdoConnected();
            AdoConnected dal = new AdoConnected();
            lstCats = dal.GetAllCats();
            return lstCats;
        }
        public string GetCategoryNameByid(int id)
        {
            AdoConnected dal = new AdoConnected();
            return dal.getCategoryNameById(id);
        }
    }
}
