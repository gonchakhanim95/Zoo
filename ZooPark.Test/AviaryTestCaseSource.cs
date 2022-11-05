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
    }
}
