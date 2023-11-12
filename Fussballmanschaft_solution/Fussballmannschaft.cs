using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fussballmanschaft_solution
{
    public class Fussballmannschaft
    {
        public string Name { get; private set; }

        Torwart torwart;
        List<Feldspieler> feldspieler;

        public Fussballmannschaft(string name, Torwart torwart, List<Feldspieler> felspieler)
        {
            this.Name = name;
            this.torwart = torwart;
            this.feldspieler = felspieler;
        }

        public int Spielzug()
        {
            Random rand = new Random();
            torwart.Schusshalten();
            feldspieler[rand.Next(feldspieler.Count)].Dribblen();
            feldspieler[rand.Next(feldspieler.Count)].AusTorSchiessen();
            feldspieler[rand.Next(feldspieler.Count)].Greatschen();
            torwart.Abstoss();
            int numberOfGoals = rand.Next(1, 4);
            bool positive = rand.Next(2) == 0 ? false : true;
            return positive ? numberOfGoals : -numberOfGoals;
        }






    }
}
