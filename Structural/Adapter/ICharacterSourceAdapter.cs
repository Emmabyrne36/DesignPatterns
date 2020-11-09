using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface ICharacterSourceAdapter
    {
        Task<IEnumerable<Person>> GetCharacters();
    }
}
