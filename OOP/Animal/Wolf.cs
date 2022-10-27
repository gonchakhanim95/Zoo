using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.options;

namespace OOP.Animal
{
    public class Wolf:Animal
    {
        public Wolf()
        {
            Name = "Carabin";
            Biome= BiomType.jungle;
            _sound = "AUUU";
            Eatings = new string[] { "Egg","Meat","Chiken" };
        }


    }
}
