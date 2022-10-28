using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.options;

namespace OOP.Animal
{
    public class WolfAnimal:AbstractAnimal
    {
        public WolfAnimal()
        {
            Name = "Carabin";
            Biome= BiomType.Jungle;
            _sound = "AUUU";
            Eatings = new string[] { "Egg","Meat","Chiken" };
            IsPredator= true;
        }


    }
}
