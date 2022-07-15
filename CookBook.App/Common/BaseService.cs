using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.App.Abstract;

namespace CookBook.App.Common
{
    public class BaseService<T> : IService<T>
    {
        public List<T> Recipes { get; set; }

        public BaseService()
        {
            Recipes = new List<T>();
        }

        public int AddRecipe(T recipe)
        {
            Recipes.Add(recipe);
            return recipe.Id;
        }

        public List<T> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public void RemoveRecipe(T recipe)
        {
            throw new NotImplementedException();
        }

        public int UpdateRecipe(T recipe)
        {
            throw new NotImplementedException();
        }
    }
}
