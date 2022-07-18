using CookBook;
using CookBook.App.Abstract;
using CookBook.App.Concrete;
using CookBook.App.Managers;
using CookBook.Domain.Entity;

MenuActionService actionService = new MenuActionService();
RecipeService recipeService = new RecipeService();
RecipeManager recipeManager = new RecipeManager(actionService, recipeService);



Console.WriteLine("Welcome to the cookbook app!");

while (true)
{



    Console.WriteLine("Please tell me what you want to do: ");


    var mainMenu = actionService.GetMenuActionsByMenuName("Main");
    for (int i = 0; i < mainMenu.Count; i++)
    {
        Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
    }

    var operation = Console.ReadKey();
    
    switch (operation.KeyChar)
    {
        case '1':
            var newId = recipeManager.AddNewRecipe();
            break;
        case '2':
            recipeManager.RemoveRecipe();
            break;
        case '3':
            recipeManager.ShowRecipeDetails();
            break;
        case '4':
            recipeManager.ShowRecipesByTypeId();
            break;
        default:
            Console.WriteLine("Actioned you entered does not exist");
            break;

    }

}






