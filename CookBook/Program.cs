using CookBook;

MenuActionService actionService = new MenuActionService();
RecipeService recipeService = new RecipeService();
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
            var keyInfo = recipeService.AddNewItemView(actionService);
            var id = recipeService.AddNewItem(keyInfo.KeyChar);
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






static MenuActionService Initialize(MenuActionService actionService)
{
    actionService.AddNewAction(1, "Add recipe", "Main");
    actionService.AddNewAction(2, "Remove recipe", "Main");
    actionService.AddNewAction(3, "Show details", "Main");
    actionService.AddNewAction(4, "Show all recipes", "Main");

    actionService.AddNewAction(1, "Breakfeast", "AddNewRecipeMenu");
    actionService.AddNewAction(2, "Dinner", "AddNewRecipeMenu");
    actionService.AddNewAction(3, "Supper", "AddNewRecipeMenu");
    

    return actionService;
}