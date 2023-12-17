using dotnet_xunit.Cocktail.Response;
using Newtonsoft.Json;

namespace dotnet_xunit.Cocktail
{
    public class CocktailAPI
    {
        private readonly HttpClient _restClient = new();
        private readonly string URI = "https://www.thecocktaildb.com/";
        private readonly string _search = "api/json/v1/1/search.php";    

        public async Task<GetIngredientResponse?> SearchIngredientByName(string ingredientName)
        {
            UriBuilder uriBuilder = new(URI)
            {
                Port = -1,
                Path = _search,
                Query = $"i={ingredientName}"
            };

            var reponse = await _restClient.GetAsync(uriBuilder.Uri);
            var context = await reponse.Content.ReadAsStringAsync();

            try
            {
                var responseModel = JsonConvert.DeserializeObject<GetIngredientResponse>(context);
                return responseModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<GetCocktailResponse?> SearchCocktailByName(string cocktailName)
        {
            UriBuilder uriBuilder = new(URI)
            {
                Port = -1,
                Path = _search,
                Query = $"s={cocktailName}"
            };

            var reponse = await _restClient.GetAsync(uriBuilder.Uri);
            var context = await reponse.Content.ReadAsStringAsync();

            try
            {
                var responseModel = JsonConvert.DeserializeObject<GetCocktailResponse>(context);
                return responseModel;
            }
            catch
            {
                return null;
            }
        }
    }
}
