﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.App.Abstract;
using CookBook.Domain.Entity;

namespace CookBook.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
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
            return Recipes;
        }

        public void RemoveRecipe(T recipe)
        {
            Recipes.Remove(recipe);
        }

        public int UpdateRecipe(T recipe)
        {
            var entity = Recipes.FirstOrDefault(p => p.Id == recipe.Id);
            if (entity != null)
            {
                entity = recipe;
            }
            return entity.Id;
        }
    }
}