using OOP.options;

namespace OOP.Animal
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Menu { get; set; }
        public double FoodWeigth { get; set; }
        public double Appetite { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public bool IsPredator { get; set; }
        public string Tyype { get; protected set; }
        public BiomType Biome { get; protected set; }
        public FoodType FoodType { get; protected set; }

        protected string Sound;

        public AbstractAnimal(string name, int age, BiomType biome, double unitToSquare, double maxFood)
        {
            Name = name;
            Age = age;
            Area = unitToSquare;
            Biome = biome;
        }


        public void Eat(string eat, int kg)
        {
            string result;
            if (!Menu.Contains(eat))
            {
                result = $"{Name} refused to {eat}";
            }
            else if (Menu.Contains(eat))
            {
                Console.WriteLine($"{Name} refused to {eat}");
            }
        }
        public virtual Message ToSound => new Message()
        {
            Text = $"{Name} makes a sound {Sound}",
            Name = Name,
            MessageType = MessageType.Play,
        };

    }
}
