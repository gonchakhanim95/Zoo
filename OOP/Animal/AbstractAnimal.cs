using OOP.options;

namespace OOP.Animal
{
    public class AbstractAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Eatings { get; set; }
        public BiomType Biome { get; protected set; }
        public double Weight { get; set; }
        public double UnitToSquareMater { get; set; }
        public bool IsPredator { get; protected set; }
        protected string _sound;

        public void Eat(string eat, int kg)
        {
            if (Eatings.Contains(eat))
            {
                Console.WriteLine($"{Name} ate {kg} kilogram {eat} pey day");
            }
            else
            {
                Console.WriteLine($"{Name} refused to {eat}");
            }
        }
        public virtual Message ToSound()
        {
            return new Message()
            {
                Text = $"{Name} makes a sound {_sound}",
                Name = Name,
                MessageType = MessageType.Play,
            };
        }

    }
}
