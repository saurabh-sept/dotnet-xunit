using dotnet_xunit.Cocktail;
using Xunit;

namespace dotnet_xunit
{
    public class CocktailTests
    {
        [Theory]
        [InlineData("margarita")]
        [InlineData("MaRgArItA")]
        public async void SearchCocktail_CaseInsensitive_ReturnsMatchingResults(string cocktailName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchCocktailByName(cocktailName);
            Assert.NotNull(response);
            Assert.NotNull(response.drinks);
        }

        [Theory]
        [InlineData("mA")]
        public async void SearchCocktail_ShortName_ReturnsAllContainingSearchText(string cocktailName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchCocktailByName(cocktailName);
            Assert.NotNull(response);
            Assert.NotNull(response.drinks);
            Assert.True(response.drinks.Length > 1);
            foreach (var cocktail in response.drinks)
            {
                Assert.Contains(cocktailName.ToLower(), cocktail.strDrink.ToLower());
            }
        }

        [Theory]
        [InlineData("xxmargaritaxx")]
        public async void SearchCocktail_InvalidName_ReturnsDrinksNull(string cocktailName)
        {
            CocktailAPI cocktailApi = new();

            var response = await cocktailApi.SearchCocktailByName(cocktailName);
            Assert.NotNull(response);
            Assert.Null(response.drinks);
        }
    }
}