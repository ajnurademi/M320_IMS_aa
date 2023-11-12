using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fussballmanschaft_solution
{
    public class Torwart
    {
        public string Name { get; private set; }

        public Torwart(string name)
        {
            Name = name;
        }

        public string Schusshalten()
        {
            return $"{Name} hält den Schuss vom Gegner";
        }

        public string Abstoss()
        {
            return $"{Name} macht einen Abstoss";
        }
    }
}
