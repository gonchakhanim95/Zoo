using OOP.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.options
{
    public class Aviaries
    {
        public string Name { get; set; }
        public string Square { get; set; }
        public string Biom { get; set; }

        public List<AbstractAnimal> Animals { get; set; }
        public Aviaries(string name, string square, string biom)
        {
            Name = name;
            Square = square;
            Biom = biom;
        }
    }

}
