using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class Program
    {

        static List<GameCharacter> CharacterSet = new List<GameCharacter>()
               {new Wizard(81,73,"Snape", 84, 93),
                new Wizard(89, 76,"Merlin", 76, 82),
                new Warrior("his mind","Magneto", 87, 87),
                new Warrior("deez mitts","Bam-Bam", 99, 1),
                new Wizard(4,8,"Ice King", 12, 12)};
        

        static void Main(string[] args)
        {

            foreach (GameCharacter character in CharacterSet)
            {
                character.Play();
            }
            Console.ReadKey();
        }


    }
}
