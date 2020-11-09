using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter
{
    public class Person
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }
        public virtual string Gender { get; set; }
        [JsonProperty("hair_colour")]
        public virtual string HairColour { get; set; }
    }
}
