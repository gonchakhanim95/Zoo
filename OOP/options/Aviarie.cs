using OOP.Animal;
using System.Text;

namespace OOP.options
{
    public class Aviarie
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int FilledArea { get; set; }
        public BiomType Biome { get; set; }
        public FoodType FoodType { get; set; }
        public List<AbstractAnimal> Animals { get; set; } = new List<AbstractAnimal>();
        
        public Aviarie(string name, int area, BiomType biome)
        {
            Name = name;
            Area = area;
            Biome = biome; 
        }

        public string AddAnimal(AbstractAnimal animal)
        {
            StringBuilder result = new StringBuilder();
            if (Biome != animal.Biome)
            {
                result.Append($"{Name} don't added in aviaries\n");
            }
            if (FoodType != animal.FoodType)
            {
                result.Append("does not fit the type of animal\n");
            }
            if (Area - FilledArea < animal.Area)
            {
                result.Append($"for {Name} there was not enough space\n");
            }
            if (result.Length == 0)
            {
                Animals.Add(animal);
            }
            return result.ToString();
        }
    }
}
