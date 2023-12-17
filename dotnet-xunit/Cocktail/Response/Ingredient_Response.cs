using Newtonsoft.Json;

namespace dotnet_xunit.Cocktail.Response
{

    public class GetIngredientResponse
    {
        public Ingredient[]? ingredients { get; set; }
    }

    public class Ingredient
    {
        [JsonProperty(Required = Required.Always)]
        public required string idIngredient { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strIngredient { get; set; }

        public string? strDescription { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strType { get; set; }

        public string? strAlcohol { get; set; }
        
        public string? strABV { get; set; }
    }

}
