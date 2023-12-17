﻿using Newtonsoft.Json;

namespace dotnet_xunit.Cocktail.Response
{

    public class GetCocktailResponse
    {
        public Drink[]? drinks { get; set; }
    }

    public class Drink
    {
        [JsonProperty(Required = Required.Always)]
        public required string idDrink { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strDrink { get; set; }
        
        public string? strDrinkAlternate { get; set; }
        
       // [JsonProperty(Required = Required.Always)]      ***Bug in Spec
        public string? strTags { get; set; }
        
        public string? strVideo { get; set; }
        
        [JsonProperty(Required = Required.Always)]
        public required string strCategory { get; set; }

        public string? strIBA { get; set; }
        
        [JsonProperty(Required = Required.Always)]
        public required string strAlcoholic { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strGlass { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strInstructions { get; set; }

        public string? strInstructionsES { get; set; }
        public string? strInstructionsDE { get; set; }
        public string? strInstructionsFR { get; set; }
        public string? strInstructionsIT { get; set; }
        public string? strInstructionsZHHANS { get; set; }
        public string? strInstructionsZHHANT { get; set; }
        public string? strDrinkThumb { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strIngredient1 { get; set; }
        
        public string? strIngredient2 { get; set; }
        public string? strIngredient3 { get; set; }
        public string? strIngredient4 { get; set; }
        public string? strIngredient5 { get; set; }
        public string? strIngredient6 { get; set; }
        public string? strIngredient7 { get; set; }
        public string? strIngredient8 { get; set; }
        public string? strIngredient9 { get; set; }
        public string? strIngredient10 { get; set; }
        public string? strIngredient11 { get; set; }
        public string? strIngredient12 { get; set; }
        public string? strIngredient13 { get; set; }
        public string? strIngredient14 { get; set; }
        public string? strIngredient15 { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strMeasure1 { get; set; }

        public string? strMeasure2 { get; set; }
        public string? strMeasure3 { get; set; }
        public string? strMeasure4 { get; set; }
        public string? strMeasure5 { get; set; }
        public string? strMeasure6 { get; set; }
        public string? strMeasure7 { get; set; }
        public string? strMeasure8 { get; set; }
        public string? strMeasure9 { get; set; }
        public string? strMeasure10 { get; set; }
        public string? strMeasure11 { get; set; }
        public string? strMeasure12 { get; set; }
        public string? strMeasure13 { get; set; }
        public string? strMeasure14 { get; set; }
        public string? strMeasure15 { get; set; }
        public string? strImageSource { get; set; }
        public string? strImageAttribution { get; set; }

        [JsonProperty(Required = Required.Always)]
        public required string strCreativeCommonsConfirmed { get; set; }

        // [JsonProperty(Required = Required.Always)]         ***Bug in Spec
        public string? dateModified { get; set; }
    }
}
