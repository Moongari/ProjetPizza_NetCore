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

        record PersonnageRecord
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

            // essayons avec la struct les structs heritent de value-Type ce sont donc des passage par valeur
            // donc personnage4 change.

            var personnage3 = new PersonnageStruct() { FirstName = "Albert", LastName = "Toto", Force = 30 };
            var personnage4 = new PersonnageStruct();
            personnage4 = personnage3;
            personnage4.FirstName = "RIRI";
            personnage4.LastName = "Ricola";
            personnage4.Force = 34;
            
            personnage3.Afficher();
            personnage4.Afficher();



            Console.WriteLine("les RECORDS");
            // avec les records on a un passage par reference avec egalement
            // des propriete d'une structure Value-Type
            // ici il est capable de cloner l'objet personn5 en un objet personn6 et modifie ces valeurs
            // ainsi les records utilise le passage par reference avec egalement la possibilité de passé des valeurs

            var personn5 = new PersonnageRecord() { FirstName = "Albert", LastName = "Toto", Force = 30 };
            var personn6 = personn5 with { };

            //personn5.FirstName = "Robert"; // ici on modifie bien l'objet personn5 on a donc cloner
          
            //passage par reference les 2 objets personnage pointent vers la meme adresse memoire
            personn5.Afficher();
            personn6.Afficher();

            // si l'on fait une comparaison d'objet
            Console.WriteLine("Resultat : "+ personn5.Equals(personn6)); // resultat false les 2 objets sont différents
            // ici le resultat est true car on test l'egalité sur le contenu des variables
            // celles ci sont bien egales
            Console.WriteLine( personn5==personn6); 
        }




    
        
    }
}
