using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeDateTime
{
    public class Personne
    {

        public int infoPer { get; set; }
        public string name { get; set; }




        public void courrir(Personne p)
        {
            Console.WriteLine($"{p.name} peut courrir a {infoPer} Km/h");
        }

        public void dormir(Personne p)
        {
            Console.WriteLine($"{p.name} dort depuis {infoPer} heures ");
        }


        public void travail(Personne p)
        {
            Console.WriteLine($"{p.name} travail depuis {infoPer} heures ");
        }
    }
}
