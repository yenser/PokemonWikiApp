using System;
using System.Text.Json.Serialization;

namespace PokemonWikiApp.Data.Models
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
