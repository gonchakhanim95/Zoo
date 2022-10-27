using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animal
{
    public class Aminals
    {
        public string Name { get; protected set; }
        public int Age { get; set; }
        public string[] Eatings { get; set; }
        public string Biome { get; protected set; }
        public double Weight { get;  set; }
        public double UnitToSquareMater { get; set; }
        public bool IsPradator { get; protected set; }
        protected string _sound;

        public Aminals(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public void Eat(string eat,int kg)
        {
            if (Eatings.Contains(eat))
            {
                Console.WriteLine($"{Name} ate {kg} kilogram {eat}");
            }

        }
        
    }
}
