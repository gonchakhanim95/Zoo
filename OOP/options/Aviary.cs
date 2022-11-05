using OOP.Animal;

namespace OOP.options
{
    public class Aviary
    {

        public string Name { get; set; }
        public int Area { get; set; }
        public int FilledArea { get; set; }
        public BiomType Biome { get; set; }
        public FoodType FoodType { get; set; }
        public List<AbstractAnimal> Animals { get; set; } = new List<AbstractAnimal>();

        public Aviary(string name, int area, BiomType biome)
        {
            Name = name;
            Area = area;
            Biome = biome;
        }

        public Message AddAnimal(AbstractAnimal animal)
        {
            if (Biome != animal.Biome)
            {
                return new Message()
                {
                    Text = $"{animal.Name} don't added in aviaries",
                    SenderName = animal.Name,
                    SenderType = "Aviary",
                    MessageType = TypeOfMessage.FailedAdding
                };
            }
            else if (FoodType != animal.FoodType)
            {
                return new Message()
                {
                    Text = "does not fit the type of animal",
                    SenderName = animal.Name,
                    SenderType = "Aviary",
                    MessageType = TypeOfMessage.FailedAdding
                };
            }
            else if (Area - FilledArea < animal.Area)
            {
                return new Message()
                {
                    Text = $"for {animal.Name} there was not enough space",
                    SenderName = animal.Name,
                    SenderType = "Aviary",
                    MessageType = TypeOfMessage.FailedAdding
                };
            }
            else
            {
                Animals.Add(animal);
                return new Message()
                {
                    Text = $"{animal.Name} added in aviary",
                    SenderName = animal.Name,
                    SenderType = "Aviary",
                    MessageType = TypeOfMessage.Adding
                };
            }

        }

        public override bool Equals(object? obj)
        {
            return obj is Aviary aviary &&
                   Name == aviary.Name &&
                   Area == aviary.Area &&
                   FilledArea == aviary.FilledArea &&
                   Biome == aviary.Biome &&
                   FoodType == aviary.FoodType &&
                   Animals.Count == aviary.Animals.Count;
        }
    }
}
