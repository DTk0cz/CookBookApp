using CookBook;
using CookBook.App.Abstract;
using CookBook.App.Concrete;
using CookBook.App.Managers;
using CookBook.Domain.Entity;

MenuActionService actionService = new MenuActionService();
RecipeManager recipeManager = new RecipeManager(actionService);

actionService = Initialize(actionService);

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
            var removeId = recipeService.RemoveRecipeView();
            recipeService.RemoveRecipe(removeId);
            break;
        case '3':
            var detailId = recipeService.RecipeDetailSelectionView();
            recipeService.RecipeDetailView(detailId);
            break;
        case '4':
            var typeId = recipeService.RecipeTypeSelectionView();
            recipeService.RecipesByTypeIdView(typeId);
            break;
        default:
            Console.WriteLine("Actioned you entered does not exist");
            break;

    }

}






