using CookBook.App.Common;
using CookBook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> results = new List<MenuAction>();
            foreach (var menuAction in Recipes)
            {
                if (menuAction.MenuName == menuName)
                {
                    results.Add(menuAction);
                }
            }

            return results;
        }

        private void Initialize()
        {
            AddRecipe(new MenuAction(1, "Add recipe", "Main"));
            AddRecipe(new MenuAction(2, "Remove recipe", "Main"));
            AddRecipe(new MenuAction(3, "Show details", "Main"));
            AddRecipe(new MenuAction(4, "Show all recipes", "Main"));

            AddRecipe(new MenuAction(1, "Breakfeast", "AddNewRecipeMenu"));
            AddRecipe(new MenuAction(2, "Dinner", "AddNewRecipeMenu"));
            AddRecipe(new MenuAction(3, "Supper", "AddNewRecipeMenu"));
        }
    }
}
