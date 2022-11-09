using OOP.options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animal
{
    public class Rabbit : AbstractAnimal
    {
        public Rabbit (string name,int age) : base(name,age)
        {
            Name = "Jojo";
            Age = age;
            Menu = new string[] { "Cabbage", "Leaves" };
            IsPredator = false;
            Area = 10;
            Biome = BiomType.Field;
        }
    }
}
