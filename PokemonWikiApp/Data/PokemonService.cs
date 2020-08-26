using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PokemonWikiApp.Data.Models;

namespace PokemonWikiApp.Data
{
    public class PokemonService
    {
        const string url = "https://pokeapi.co/api/v2";

        private readonly IHttpClientFactory _clientFactory;

        public PokemonService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<PokemonResponse> GetPokemon(int skip = 0, int limit = 20)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url + $"/pokemon?skip={skip}&limit={limit}");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<PokemonResponse>();
            }
            else
            {
                return null;
            }
        }
    }
}