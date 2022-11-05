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
        public List<AbstractAnimal> Animals { get; set; }
        public BiomType Biome { get; set; }
        public FoodType FoodType { get; protected set; }

        protected string Sound;

        public AbstractAnimal(string name, int age)
        {
            Name = name;
            Age = age;
            Animals = new List<AbstractAnimal>();
        }

        public virtual string Feed(string eat, double foodWeigth)
        {
            string result;
            if (!Menu.Contains(eat))
            {
                result = $"{Name} refused to {eat}";
            }
            else if (foodWeigth>Appetite)
            {
                result = $"{foodWeigth} kg is too much for {Name}";
            }
            else
            {
                result = $"{Name} ate {foodWeigth} kq of {eat}";
            }

            return result;
        }
        
        public virtual Message ToSound => new Message()
        {
            Text = $"{Name} makes a sound {Sound}",
            SenderName = Name,
            MessageType = (TypeOfMessage)MessageType.Play
        }; 
    }
}
