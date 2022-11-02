using OOP.options;


namespace OOP.Animal
{
    public class WolfAnimal : AbstractAnimal
    {
        public WolfAnimal(string name, int age) : base(name, age)
        {
            Name = "Carabin";
            Biome = BiomType.Jungle;
            _sound = "AUUU";
            Eatings = new string[] { "Egg", "Meat", "Chiken" };
            IsPredator = true;
            UnitToSquareMater = 15;
        }



        public override Message ToSound()
        {
            return new Message()
            {
                Text = $"{Name} makes a sound {_sound} when the moon is full",
                Name = Name,
                
            };
        }
    }
}



