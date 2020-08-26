using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonWikiApp.Data.Models
{
    public class PokemonResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public Uri Next { get; set; }

        [JsonPropertyName("previous")]
        public Uri Previous { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<Pokemon> Results { get; set; }

    }
}
