using CookBook.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.App
{
    internal class RecipeService : BaseService<Recipe>
    {


        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewRecipeMenu");
            Console.WriteLine("Please select recipe type:");
            for(int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            return operation;
        }

        public int AddNewItem(char recipeType)
        {
            int recipeTypeId;
            Int32.TryParse(recipeType.ToString(), out recipeTypeId);
            Recipe recipe = new Recipe();
            recipe.TypeId = recipeTypeId;
            Console.WriteLine("Please enter id for new recipe:");
            var id = Console.ReadLine();
            int recipeId;
            Int32.TryParse(id, out recipeId);
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();

            recipe.Id = recipeId;
            recipe.Name = name;
            recipe.TypeId = recipeTypeId;

            Recipes.Add(recipe);
            return recipeId;

            
        }

        public int RemoveRecipeView()
        {
            Console.WriteLine("Please enter id for recipe you want to remove:");
            var recipeId = Console.ReadKey();
            int id;
            Int32.TryParse(recipeId.KeyChar.ToString(), out id);

            return id;
        }

        public void RemoveRecipe(int removeId)
        {
            Recipe recipeToRemove = new Recipe();
            foreach(var recipe in Recipes)
            {
                if(recipe.Id == removeId)
                {
                    recipeToRemove = recipe;
                    break;
                }
            }

            Recipes.Remove(recipeToRemove);
        }

        public int RecipeTypeSelectionView()
        {
            Console.WriteLine("Please enter Type id for items you want to show:");
            var recipeId = Console.ReadKey();
            int id;
            Int32.TryParse(recipeId.KeyChar.ToString(), out id);

            return id;
        }

        public void RecipesByTypeIdView(int typeId)
        {
            List<Recipe> toShow = new List<Recipe>();
            foreach(var recipe in Recipes)
            {
                if(recipe.TypeId == typeId)
                {
                    toShow.Add(recipe);
                }
            }

            for(int i = 0; i < toShow.Count; i++)
            {
                Console.WriteLine($"Id {toShow[i].Id}, Name {toShow[i].Name}");
            }
        }

        public void RecipeDetailView(int detailId)
        {
            Recipe recipeToShow = new Recipe();
            foreach(var recipe in Recipes)
            {
                if(recipe.Id == detailId)
                {
                    recipeToShow = recipe;
                    break;
                }
            }

            Console.WriteLine($"Recipe id: {recipeToShow.Id}");
            Console.WriteLine($"Recipe name: {recipeToShow.Name}");
            Console.WriteLine($"Recipe type: {recipeToShow.TypeId}");
        }

        public int RecipeDetailSelectionView()
        {
            Console.WriteLine("Please enter id for recipe you want to show: ");
            var recipeId = Console.ReadKey();
            int id;
            Int32.TryParse(recipeId.KeyChar.ToString(), out id);

            return id;
        }
    }
}
