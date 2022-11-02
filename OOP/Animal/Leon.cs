namespace OOP.Animal
{
    public class LeonAnimal : AbstractAnimal
    {
        public LeonAnimal(string name,int age):base(name, age)
        {
            Name = "Alex";
            Age = age;
            _sound = "Roarr";
            Eatings = new string[] { "Meat","Chiken" };
            IsPredator = true;
        }

        
    }
}
