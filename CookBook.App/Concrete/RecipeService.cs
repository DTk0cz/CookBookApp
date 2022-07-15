using CookBook.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Domain;
using CookBook.Domain.Entity;

namespace CookBook.App.Concrete
{
    public class RecipeService : BaseService<Recipe>
    {




        //    var operation = Console.ReadKey();
        //    return operation;
        //}

        //public int RecipeTypeSelectionView()
        //{
        //    Console.WriteLine("Please enter Type id for items you want to show:");
        //    var recipeId = Console.ReadKey();
        //    int id;
        //    Int32.TryParse(recipeId.KeyChar.ToString(), out id);

        //    return id;
        //}

        //public void RecipesByTypeIdView(int typeId)
        //{
        //    List<Recipe> toShow = new List<Recipe>();
        //    foreach(var recipe in Recipes)
        //    {
        //        if(recipe.TypeId == typeId)
        //        {
        //            toShow.Add(recipe);
        //        }
        //    }

        //    for(int i = 0; i < toShow.Count; i++)
        //    {
        //        Console.WriteLine($"Id {toShow[i].Id}, Name {toShow[i].Name}");
        //    }
        //}

        //public void RecipeDetailView(int detailId)
        //{
        //    Recipe recipeToShow = new Recipe();
        //    foreach(var recipe in Recipes)
        //    {
        //        if(recipe.Id == detailId)
        //        {
        //            recipeToShow = recipe;
        //            break;
        //        }
        //    }

        //    Console.WriteLine($"Recipe id: {recipeToShow.Id}");
        //    Console.WriteLine($"Recipe name: {recipeToShow.Name}");
        //    Console.WriteLine($"Recipe type: {recipeToShow.TypeId}");
        //}

        //public int RecipeDetailSelectionView()
        //{
        //    Console.WriteLine("Please enter id for recipe you want to show: ");
        //    var recipeId = Console.ReadKey();
        //    int id;
        //    Int32.TryParse(recipeId.KeyChar.ToString(), out id);

        //    return id;
        //}
    }
}
