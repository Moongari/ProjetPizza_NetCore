using System;


namespace ProgrammeDateTime
{



    // Nouveaute C#9
    // Top-Level-Programs
    // init-only properties
    //records

    

  


    public class Program
    {
        public class Personne
        {
            public string nom { get; init; } // init-only uniquement a la construction de l'objet
            public int age { get; set; }


            public void afficher()
            {
                Console.WriteLine($"{nom} - {age}");
            }
        }

        static void  Main(string[] args)
        {
            Console.WriteLine("Hello Moon C#9");

            Personne person = new Personne() { age = 30, nom = "TOTO" };
            person.afficher();

        }




    
        
    }
}
