using OOP.options;

namespace OOP.Animal
{
    public class Leon : AbstractAnimal
    {
        public Leon(string name,int age, BiomType biome, double unitToSquare, double maxFood) :base(name, age,biome, unitToSquare, maxFood)
        {
            Name = "Alex";
            Age = age;
            Sound = "Roarr";
            Menu = new string[] { "Meat","Chiken" };
            IsPredator = true;
        }

        
    }
}
