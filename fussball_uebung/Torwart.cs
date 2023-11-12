using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_uebung
{
    public class Torwart
    {
        public readonly string Name;

        public Torwart(string name)
        {
            this.Name = name;
        }

        public string SchussHalten()
        {
            return $"{Name} hat den Schuss gehalten";
        }

        public string Abstoss()
        {
            return $"{Name} hat einen Abstoss gemacht";
        }
    }
}
