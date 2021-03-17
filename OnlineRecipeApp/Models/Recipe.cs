using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace OnlineRecipeApp.Models
{
    public class Recipe
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]

        public string RecipeName { get; set; }
        public string Picture { get; set; }
        [Required]
        public string Description { get;set; }
        public string CategoryName { get; set; }
        public int size { get; set; }
    }
}