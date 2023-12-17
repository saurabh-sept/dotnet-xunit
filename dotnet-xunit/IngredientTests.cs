using dotnet_xunit.Cocktail;
using Xunit;

namespace dotnet_xunit
{
    public class IngredientTests
    {
        [Theory]
        [InlineData("vodka")]
        [InlineData("VoDkA")]
        public async void SearchIngredient_CaseInsensitive_Alcoholic_ReturnsABVNotNull(string ingredientName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchIngredientByName(ingredientName);
            Assert.NotNull(response);
            Assert.NotNull(response.ingredients);
            Assert.Single(response.ingredients);
            Assert.Equal("Yes", response.ingredients.First().strAlcohol);
            Assert.NotNull(response.ingredients.First().strABV);
        }

        [Theory]
        [InlineData("water")]
        [InlineData("WaTeR")]
        public async void SearchIngredient_CaseInsensitive_NonAlcoholic_ReturnsABVNull(string ingredientName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchIngredientByName(ingredientName);
            Assert.NotNull(response);
            Assert.NotNull(response.ingredients);
            Assert.Single(response.ingredients);
            Assert.Equal("No", response.ingredients.First().strAlcohol);
            Assert.Null(response.ingredients.First().strABV);
        }

        [Theory]
        [InlineData("v")]
        public async void SearchIngredient_ShortName_ReturnsTopMatchingIngredient(string ingredientName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchIngredientByName(ingredientName);
            Assert.NotNull(response);
            Assert.NotNull(response.ingredients);
            Assert.Single(response.ingredients);
            Assert.StartsWith(ingredientName.ToLower(), response.ingredients.First().strIngredient.ToLower());
        }

        [Theory]
        [InlineData("xxwaterxx")]
        public async void SearchIngredient_InvalidName_ReturnsIngredientsNull(string ingredientName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchIngredientByName(ingredientName);
            Assert.NotNull(response);
            Assert.Null(response.ingredients);
        }
    }
}