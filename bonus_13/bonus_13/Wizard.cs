using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class Wizard : MagicUsingCharacter
    {
        

        public Wizard(int spellNumber, int magicalEnergy, string name, int strength, int intelligence): base(magicalEnergy, name, strength,intelligence)
        {
            _spellNumber = spellNumber;
        }

        public override void Play(int spellNumber, int magicalEnergy, string name, int strength, int intelligence, string weaponType)
        {
            Console.WriteLine($"{_name}\'s strength is {_strength.ToString()}, " +
                $"intelligence is {_intelligence.ToString()}, magical energy is {_magicalEnergy.ToString()}, and their spellnumber is {_spellNumber.ToString()}.");
        }
    }
}
