using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bonus_13
{
    class GameCharacter
    {
        public string  _name;
        public int _strength;
        public int _intelligence;
        public string _weaponType;
        public int _spellNumber;
        public int _magicalEnergy;

        public GameCharacter(string name, int strength, int intelligence)
         {

            _name = name;
            _strength = strength;
            _intelligence = intelligence;

         }

        public virtual void Play(int spellNumber, int magicalEnergy, string name, int strength, int intelligence, string weaponType)
        {
            Console.WriteLine($"{_name}\'s strength is {_strength.ToString()} and intelligence is {_intelligence.ToString()}.");

        }

    }
}
