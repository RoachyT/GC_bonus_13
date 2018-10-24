using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bonus_13
{
    class GameCharacter
    {
        protected string  _name;
        protected int _strength;
        protected int _intelligence;
        
        
       

        public GameCharacter(string name, int strength, int intelligence)
         {

            _name = name;
            _strength = strength;
            _intelligence = intelligence;

         }

        public virtual void Play()
        {
            Console.WriteLine($"{_name}\'s strength is {_strength.ToString()} and intelligence is {_intelligence.ToString()}.");

        }

    }
}
