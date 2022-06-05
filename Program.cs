using System;


namespace ProgrammeDateTime
{



    // Nouveaute C#9
    // Top-Level-Programs
    // init-only properties
    //records nouveaute du langage C#9

    

  


    public class Program
    {


        // creation d'un objet Personnage
        class Personnage
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public  int Force { get; set; }
            public void Afficher()
            {
                Console.WriteLine($"{FirstName} - {LastName} - {Force}");
            }
        }

        struct PersonnageStruct
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Force { get; set; }

            public void Afficher()
            {
                Console.WriteLine($"{FirstName} - {LastName} - {Force}");
            }
        }
      
        // notion passage par valeur et passage par référence

        static void  Main(string[] args)
        {
            Console.WriteLine("Passage par reference");

            var personnage1 = new Personnage() { FirstName = "Albert", LastName = "Toto", Force = 30 };
            var personnage2 = new Personnage();

            personnage2 = personnage1;
            //passage par reference les 2 objets personnage pointent vers la meme adresse memoire
            personnage1.Afficher();
            personnage2.Afficher();

            Console.WriteLine("Passage par valeur");
            // essayons avec la struct 

            var personnage3 = new PersonnageStruct() { FirstName = "Albert", LastName = "Toto", Force = 30 };
            var personnage4 = new PersonnageStruct();
            personnage4.FirstName = "RIRI";
            personnage4.LastName = "Ricola";
            personnage4.Force = 34;
            personnage3.Afficher();
            personnage4.Afficher();
        }




    
        
    }
}
