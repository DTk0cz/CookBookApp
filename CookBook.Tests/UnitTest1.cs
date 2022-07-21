using CookBook.App.Abstract;
using CookBook.App.Concrete;
using CookBook.App.Managers;
using CookBook.Domain.Entity;
using Moq;
using System;
using Xunit;

namespace CookBook.Tests

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Recipe recipe = new Recipe(1, "Burger", 2);
            var mock = new Mock<IService<Recipe>>();
            mock.Setup(s => s.GetRecipeById(1)).Returns(recipe);

            var manager = new RecipeManager(new MenuActionService(), mock.Object);
            //Act

            var returnedRecipe = manager.GetRecipeById(recipe.Id);
            //Assert
            
            Assert.Equal(recipe, returnedRecipe);
           
        }
    }
}