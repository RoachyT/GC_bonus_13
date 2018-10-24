using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class MagicUsingCharacter : GameCharacter
    {

        public int _magicalEnergy;
        public MagicUsingCharacter(int magicalEnergy, string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            _magicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"{_name}\'s strength is {_strength.ToString()}," +
                $" intelligence is {_intelligence.ToString()}, and their magical energy is{_magicalEnergy.ToString()}.");

        }
    }
}
