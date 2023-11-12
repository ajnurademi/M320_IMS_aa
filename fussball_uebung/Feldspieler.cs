using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_uebung
{
    public class Feldspieler
    {
        public readonly string Name;

        public Feldspieler(string name)
        {
            this.Name = name;
        }

        public string AufTorSchiessen()
        {
            return $"{Name} hat auf Tor geschossen";
        }

        public string Greatschen()
        {
            return $"{Name} hat eine Greatche gemacht";
        }

        public string Dribblen()
        {
            return $"{Name} hat eine den Gegenspieler ausgedrbbelt";
        }


    }
}
