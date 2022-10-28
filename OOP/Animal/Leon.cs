namespace OOP.Animal
{
    public class LeonAnimal : AbstractAnimal
    {
        public LeonAnimal(string name)
        {
            Name = "Alex";
            Age = 1;
            _sound = "Roarr";
            Eatings = new string[] { "Meat","Chiken" };
            IsPredator = true;
        }

        public LeonAnimal(string name, int age)
        {
            Name = "Max";
            Age = age;
            _sound = "Roarr";
            Eatings = new string[] { "Meat", "Chiken" };
            IsPredator= true;
        }
        
    }
}
