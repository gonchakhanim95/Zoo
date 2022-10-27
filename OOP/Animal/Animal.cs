using OOP.options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Eatings { get; set; }
        public BiomType Biome { get; protected set; }
        public double Weight { get;  set; }
        public double UnitToSquareMater { get; set; }
        public bool IsPradator { get; protected set; }
        protected string _sound;

        public void Eat(string eat,int kg)
        {
            if (Eatings.Contains(eat))
            {
                Console.WriteLine($"{Name} ate {kg} kilogram {eat} pey day");
            }

        }
        public void ToSound()
        {
            Console.WriteLine($"{Name} makes a sound {_sound}");
        }
     

    }
}
