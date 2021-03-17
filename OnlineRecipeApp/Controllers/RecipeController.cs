using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecipeEntities;
using RecipeBusinessLib;

namespace OnlineRecipeApp.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Index()
        {
            BusinessLayer bll = new BusinessLayer();
            var lstRes = bll.GetAllCtas()
                           .Select(o => new Models.Category
                           {
                               CategoryId = o.CategoryId,
                               CategoryName = o.CategoryName,
                               
                           });
            return View(lstRes);
        }
       
        
        
        public ActionResult Rec(int id)
        {
            BusinessLayer bll = new BusinessLayer();
            var name = bll.GetCategoryNameByid(id);
            var count = bll.GetResById(id).Count;
            var lstRes = bll.GetResById(id)
                           .Select(o => new Models.Recipe
                           {
                               CategoryId = o.CategoryId,
                               RecipeName = o.RecipeName,
                               Picture = o.Picture,
                               Description = o.Description,
                               CategoryName = name,
                               size=count
                           });
            return View(lstRes);
        }
   
    }
  
}