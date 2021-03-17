using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RecipeEntities;

namespace RecipeDataLib
{
    
    public class AdoConnected:RecipeInterface
    {
        SqlConnection con;
        SqlCommand cmd;
        public AdoConnected()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-7N52913;Initial Catalog=HRMSDB;Integrated Security=True";


        }
        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> lstRes = new List<Recipe>();
            //configure sql command for select all
            cmd = new SqlCommand();
            cmd.CommandText = "select categoryid,recipename,picture,description from recipe";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;
            con.Open();


            //execute the command
            SqlDataReader sdr = cmd.ExecuteReader();
            //traverser the recorf of the datareader one by one
            while (sdr.Read())
            {
                Recipe res = new Recipe
                {
                    CategoryId = (int)sdr[0],
                    RecipeName = (string)sdr[1],
                    Picture = (string)sdr[2],
                    Description = (string)sdr[3]

                };
                //add record to collection
                lstRes.Add(res);


            }
            sdr.Close();
            con.Close();
            return lstRes;

            //throw new NotImplementedException();
        }

        public List<Recipe> GetRecipesById(int id)
        {
            List<Recipe> lstRes = new List<Recipe>();
            //configure sql command for select all
            cmd = new SqlCommand();
            cmd.CommandText = "select categoryid,recipename,picture,description from recipe where categoryid="+id;
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;
            con.Open();


            //execute the command
            SqlDataReader sdr = cmd.ExecuteReader();
            //traverser the recorf of the datareader one by one
            while (sdr.Read())
            {
                Recipe res = new Recipe
                {
                    CategoryId = (int)sdr[0],
                    RecipeName = (string)sdr[1],
                    Picture = (string)sdr[2],
                    Description = (string)sdr[3]

                };
                //add record to collection
                lstRes.Add(res);


            }
            sdr.Close();
            con.Close();
            return lstRes;
            // throw new NotImplementedException();
        }
        public List<Category> GetAllCats()
        {
            List<Category> lstCat = new List<Category>();
            //configure sql command for select all
            cmd = new SqlCommand();
            cmd.CommandText = "select categoryid,categoryname from category";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;
            con.Open();


            //execute the command
            SqlDataReader sdr = cmd.ExecuteReader();
            //traverser the recorf of the datareader one by one
            while (sdr.Read())
            {
                Category res = new Category
                {
                    CategoryId = (int)sdr[0],
                    CategoryName = (string)sdr[1],
                   

                };
                //add record to collection
                lstCat.Add(res);


            }
            sdr.Close();
            con.Close();
            return lstCat;
        }
        public string getCategoryNameById(int id)
        {
            string name;
            cmd = new SqlCommand();
            cmd.CommandText = "select categoryname from category where categoryid=" + id;
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            name = (string)sdr[0];

            sdr.Close();
            con.Close();
            return name; 
        }
    }
}
