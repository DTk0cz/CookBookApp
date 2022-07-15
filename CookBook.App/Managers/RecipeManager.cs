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
            var id = _recipeService.GetNewId();
            Recipe recipe = new Recipe(id+1, name, typeId);
            _recipeService.AddRecipe(recipe);

            return recipe.Id;
        }
    }
}
