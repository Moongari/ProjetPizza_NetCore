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


        // une autre facon de créer un record avec le principe de Deconstruct
        // qui permet de recuperer les valeurs nom et type
        record Arbres
        {
            public string Name { get; init; }
            public string espece { get; init; }
            public Arbres(string nom, string espece)
            {
                this.espece = espece;
                this.Name = nom;
            }

            public void Deconstruct (out string nom, out string espece)
            {
                nom =this.Name;
                espece = this.espece;    
            }
        }

  

        static void  Main(string[] args)
        {
            // autre utilisation des Record avec le principe de deconstructeur
            var animal = new Animal("chien", "cannide", typeAnimal.carnivore);
            var (nom, race, type) = animal; // grace a cela on recupere les données passe au constructeur
            // par le biais du Deconstruct


            Console.WriteLine(nom);
            Console.WriteLine(race);
            Console.WriteLine(typeAnimal.carnivore);

            var arbres = new Arbres("sapin", "connifere");

            var (name, espece) = arbres;

            Console.WriteLine($"{name}----{espece}");


        }




    
        
    }
}
