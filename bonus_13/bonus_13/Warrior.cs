using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class Warrior : GameCharacter
    {
        public string _weaponType;

        public Warrior(string weaponType, string name, int strength, int intelligence): base (name,strength,intelligence)
        {
            _weaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"{_name}\'s strength is {_strength.ToString()}, intelligence is {_intelligence.ToString()} and weapon of choice is {_weaponType}.");
        }
    }
}
