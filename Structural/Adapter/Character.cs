using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter
{
    public class Character
    {
        [JsonProperty("name")]
        public string FullName { get; set; }
        public string Gender { get; set; }
        [JsonProperty("hair_colour")]
        public string Hair { get; set; }
    }
}
