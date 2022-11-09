using OOP.Animal;
using OOP.options;
using System.Collections;


namespace ZooPark.Test
{
    public class AviaryTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal animal =new Leon("Alex",2);
            Aviary aviary =new Aviary("ForPredators",50,BiomType.Jungle);

            Aviary expectedAviary = new Aviary("ForPredators", 50,BiomType.Jungle);
            expectedAviary.Animals.Add(new Leon("Alex", 2));

            Message expectedMessage = new Message()
            {
                Text = $"{animal.Name} added in aviary",
                SenderName = animal.Name,
                SenderType = "Aviary",
                MessageType = TypeOfMessage.Adding
            };

            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };
        }

        public IEnumerator GettEnumerator()
        {
            AbstractAnimal animal = new Rabbit("Jojo",1);
            Aviary aviary = new Aviary("ForHerbivorous", 5, BiomType.Field);

            Aviary expectedAviary = new Aviary("ForHerbivorous", 40, BiomType.Field);
            expectedAviary.Animals.Add(new Rabbit("Jojo", 1));

            Message expectedMessage = new Message()
            {
                Text = $"{animal.Name} added in aviary",
                SenderName = animal.Name,
                SenderType = "Aviary",
                MessageType = TypeOfMessage.Adding
            };
            yield return new object[] {animal, aviary, expectedAviary, expectedMessage };


        }
    }
}
