using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter
{
    public class CharacterFileSource
    {
        public async Task<List<Character>> GetCharactersFromFile(string filename) =>
            JsonConvert.DeserializeObject<List<Character>>(await File.ReadAllTextAsync(filename));
    }
}
