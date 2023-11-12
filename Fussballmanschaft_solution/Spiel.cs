using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmanschaft_solution
{
    public class Spiel
    {
        private List<Fussballmannschaft> mannschaften;
        private Result? resultat;

        public Spiel(List<Fussballmannschaft> fussballmannschaften) 
        {
            this.mannschaften = fussballmannschaften;
        }

        public void Spielen()
        {
            Console.WriteLine($"Der Schiedsrichter pfeifft das Spiel zwischen {mannschaften[0].Name} und {mannschaften[1].Name} an");
            int[] tore = new int[2];
            for (int i = 0; i < mannschaften.Count(); i++)
            {
                int geschosseneTore = mannschaften[i].Spielzug();
                int indexDerAnderenMannschaft = i == 0 ? 1 : 0;
                int mannschaftDieToreSchiesstIndex = geschosseneTore > 0 ? i : indexDerAnderenMannschaft;
                SchreibeToreAufKonsole(Math.Abs(geschosseneTore), mannschaftDieToreSchiesstIndex);
                tore[mannschaftDieToreSchiesstIndex] += Math.Abs(geschosseneTore);
            }
            resultat = new Result(tore[0], tore[1]);
        }

        private void SchreibeToreAufKonsole(int anzahl, int mannschaftsIndex)
        {
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"{mannschaften[mannschaftsIndex].Name} schiessen ein Tor!");
            }
        }
        public void SchreibeResultatAufKonsole()
        {
            Console.WriteLine("Der Schiedsrichter pfeifft das Spiel ab");
            Console.WriteLine($"{mannschaften[0].Name} {resultat} {mannschaften[1].Name}");
        }



    }
}
