using OOP.options;

namespace OOP.Animal
{
    public class Wolf : AbstractAnimal
    {
        public Wolf(string name, int age) : base(name, age)
        {
            Name = "Carabin";
            Biome = BiomType.Jungle;
            Sound = "AUUU";
            Menu = new string[] { "Egg", "Meat", "Chiken" };
            IsPredator = true;
            Area = 15;
            Tyype = "Wolf";
            
        }

        public override Message ToSound => new Message()
        {
            Text = $"{Name} make a sound {Sound} when the full moon"
        };
        
    }
}



