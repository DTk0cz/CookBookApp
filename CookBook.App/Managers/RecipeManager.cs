using CookBook.App.Abstract;
using CookBook.App.Concrete;
using CookBook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.App.Managers
{
    public class RecipeManager
    {
        private readonly MenuActionService _actionService;
        private RecipeService _recipeService;
        public RecipeManager(MenuActionService actionService)
        {
            _recipeService = new RecipeService();
            _actionService = actionService;
        }
        public int AddNewRecipe()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewRecipeMenu");
            Console.WriteLine("Please select recipe type:");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Please insert recipe name: ");
            var name = Console.ReadLine();
            var lastId = _recipeService.GetLastId();
            Recipe recipe = new Recipe(lastId+1, name, typeId);
            _recipeService.AddRecipe(recipe);
            return recipe.Id;
        }


        public void RemoveRecipe()
        {
            int idToRemove;
            Console.WriteLine("Please insert an Id of recipe you want to remove: ");
            var operation = Console.ReadKey();
            Int32.TryParse(operation.KeyChar.ToString(), out idToRemove);
            var recipeToRemove = _recipeService.GetRecipeById(idToRemove);
            _recipeService.RemoveRecipe(recipeToRemove);
            
        }

        public void ShowRecipeDetails()
        {
            int idToShow;
            Console.WriteLine("Please insert an Id of recipe you want to check details ");
            var operation = Console.ReadKey();
            Int32.TryParse(operation.KeyChar.ToString(), out idToShow);
            var recipeToShow = _recipeService.GetRecipeById(idToShow);
            Console.WriteLine($"Id: {recipeToShow.Id} Name: {recipeToShow.Name} TypeId: {recipeToShow.TypeId}");

        }

        public void ShowRecipesByTypeId()
        {
            int typeIdToShow;
            Console.WriteLine("Please insert TypeId of product you want to check: ");
            var operation = Console.ReadKey();
            Int32.TryParse(operation.KeyChar.ToString(), out typeIdToShow);
            var recipesByTypeId = _recipeService.GetAllRecipes().Where(p => p.TypeId == typeIdToShow);
            foreach(var recipe in recipesByTypeId)
            {
                Console.WriteLine($"Id: {recipe.Id} Name: {recipe.Name} TypeId: {recipe.TypeId}");
            }
            
        }
    }
}
