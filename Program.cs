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


         enum typeAnimal
        {
            carnivore,
            herbivore
        }

        // grace au record nous pouvons tout a fait créer des objets simple
        // il construit automatiquement un constructeur et Deconstruct 
        //mais egalement des getters et setter de type {get; init} uniquement a l'initialisation de
        //l'objet
        record Animal(string nom, string race,  typeAnimal type);

  

        static void  Main(string[] args)
        {
            // autre utilisation des Record avec le principe de deconstructeur
            var animal = new Animal("chien", "cannide", typeAnimal.carnivore);
            var (nom, race, type) = animal;

            Console.WriteLine(nom);
            Console.WriteLine(race);
            Console.WriteLine(typeAnimal.carnivore);



        }




    
        
    }
}
