using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_uebung
{
    public class Fussballmannschaft
    {
        public readonly string Name;
        Torwart torwart;
        List<Feldspieler> feldspieler;


        public Fussballmannschaft(string name, Torwart torwart, List<Feldspieler> feldspieler)
        {
            Name = name;
            this.torwart = torwart;
            this.feldspieler = feldspieler;
        }


        public int Spielzug()
        {
            Random random = new Random();
            int zufallsAktion = random.Next(3);
            Feldspieler feldspieler = new Feldspieler();

            switch (zufallsAktion)
            {
                case 0:
                    Console.WriteLine(feldspieler.Dribblen());
                    break;
                case 1:
                    Console.WriteLine(feldspieler.AufTorSchiessen());
                    break;
                case 2:
                    Console.WriteLine(feldspieler.Dribblen());
                    break;
            }

            int zufallAktion = random.Next(0, 1);

            switch (zufallAktion)
            {
                case 0:
                    Console.WriteLine(torwart.SchussHalten());
                    break;
                case 1:
                    Console.WriteLine(torwart.Abstoss());
                    break;
            }

            int tore = random.Next(6);

            return tore;
        }
    }
}
