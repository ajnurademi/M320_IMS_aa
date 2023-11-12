using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fussballmanschaft_solution
{
    public class Feldspieler
    {
        public string Name { get; private set; }

        public Feldspieler(string name)
        {
            Name = name;
        }

        public string AusTorSchiessen()
        {
            return $"{Name} schiesst aufs Tor!";
        }

        public string Greatschen()
        {
            return $"{Name} macht eine Blutgreatsche!";
        }

        public string Dribblen()
        {
            return $"{Name} dribbelt den Spieler schwindelig!";
        }


    }
}
