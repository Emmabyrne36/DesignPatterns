using System;

namespace DesignPatterns.Structural.Adapter
{
    public class CharacterToPersonAdapter : Person
    {
        private readonly Character _character;

        public CharacterToPersonAdapter(Character character)
        {
            _character = character ?? throw new ArgumentNullException(nameof(character));
            _character = character;
        }

        public override string Name
        {
            get => _character.FullName;
            set => _character.FullName = value;
        }

        public override string HairColour
        {
            get => _character.Hair;
            set => _character.Hair = value;
        }
    }
}
