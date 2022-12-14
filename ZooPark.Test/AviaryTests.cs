using OOP.Animal;
using OOP.options;
using System.Text;

namespace ZooPark.Test
{
    public class AviaryTests
    {
        [TestCaseSource(typeof(AviaryTestCaseSource))]
        public void AddPredatorAnimalTest(AbstractAnimal animal,Aviary aviary ,Aviary expectedAviary,Message expectedMessage)
        {
            Message actualMessage = aviary.AddAnimal(animal);
            Aviary actualAviary = aviary;

            Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestCaseSource(typeof(AviaryTestCaseSource))]
        public void AddHerbivorousAnimalTest(AbstractAnimal animal, Aviary aviary, Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage = aviary.AddAnimal(animal);
            Aviary actualAviary = aviary;

            Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}