namespace OOP.Animal
{
    public class Leon : Animal
    {
        public Leon(string name)
        {
            Name = "Alex";
            Age = 1;
            _sound = "Roarr";
            Eatings = new string[] { "Meat","Chiken" };
        }

        public Leon(string name, int age)
        {
            Name = "Max";
            Age = 3;
            _sound = "Roarr";
            Eatings = new string[] { "Meat", "Chiken" };
        }
        
    }
}
