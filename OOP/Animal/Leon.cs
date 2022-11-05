using OOP.options;

namespace OOP.Animal
{
    public class Leon : AbstractAnimal
    {
        public Leon(string name,int age) :base(name, age)
        {
            Name = "Alex";
            Age = age;
            Biome = BiomType.Jungle;
            Sound = "Roarr";
            Menu = new string[] { "Meat","Chiken" };
            IsPredator = true;
            Area = 50;
        }
    }
}
