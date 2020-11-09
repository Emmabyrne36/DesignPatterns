using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter
{
    public class StarWarsApi
    {
        public async Task<List<Person>> GetCharacters()
        {
            using (var client = new HttpClient())
            {
                string url = ApiConstants.SWAPI_PEOPLE_ENDPOINT;
                string result = await client.GetStringAsync(url);
                var people = JsonConvert.DeserializeObject<ApiResult<Person>>(result).Results;

                return people;
            }
        }
    }

    public class StarWarsApiCharacterSourceAdapter : ICharacterSourceAdapter
    {
        private StarWarsApi _starWarsApi;
        public StarWarsApiCharacterSourceAdapter(StarWarsApi starWarsApi)
        {
            _starWarsApi = starWarsApi;
        }

        public async Task<IEnumerable<Person>> GetCharacters()
        {
            return await _starWarsApi.GetCharacters();
        }
    }

    public class ApiResult<T>
    {
        public int Count { get; set; }
        public List<T> Results { get; set; }
    }

    public static class ApiConstants
    {
        // NOTE: swapi.dev collection URIs must end with a / or you will get 301 redirect errors
        public const string SWAPI_BASE_URI = "https://swapi.dev/";
        public static readonly string SWAPI_PEOPLE_ENDPOINT = $"{SWAPI_BASE_URI}api/people/";
    }
}
