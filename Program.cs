using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetPizza
{





    public class PizzaPersonnalise : Pizza
    {

        static int index = 0;
        public PizzaPersonnalise() : base("Personnalise",5f,false,null)
        {
            ingredients = new List<string>();

            index++;
            this.nom = this.nom +"" + index;
           

            while (true)
            {
                Console.WriteLine("Entrez la liste de vos ingredients");
                string ingredient = Console.ReadLine();

           
                if (String.IsNullOrWhiteSpace(ingredient)) { break; }

                if (!ingredients.Contains(ingredient))
                {
                    ingredients.Add(ingredient);
                    this.prix = this.prix + 1.5f;
                }
              
                Console.WriteLine(String.Join("," ,ingredients));

            }

        }

        

    }

    /// <summary>
    /// Classe Pizza
    /// </summary>
    public class Pizza
    {
        public string nom { get; set; }
        public float prix { get; init ; }
        public bool vegetarienne = false;
        public List<String> ingredients { get; protected set; }

        public Pizza()
        {
         
        }

        public Pizza(string nom, float prix,bool vegetarienne,List<String> ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;
        }

        /// <summary>
        /// Cette methode affiche uniquement les données 
        /// elle ne doit pas modifier les données
        /// </summary>
        public void afficher()
        {

          
            string badgeVegetarienne = vegetarienne ?  " (V) " : "";

            // cette synthaxe permet de modifier le nom sans alterer la variable nom instance de la classe Pizza
            //  nomMinuscules[1..] cette synthaxe permet de dire que toutes les autres caracteres seront en minuscules

            
            string nomAfficher = FormatPremierLettreMajuscule(nom);

            Console.WriteLine($" nom : {nomAfficher} {badgeVegetarienne} - prix : {prix} € ");

            // utilisation de le requete linq afin de parcourir les elements et les formatés
            var ingredientAfficher = ingredients.Select(i=> FormatPremierLettreMajuscule(i)).ToList();

           
           
            Console.WriteLine(String.Join(",", ingredientAfficher));
            
            Console.WriteLine();
                
        }

        /// <summary>
        /// Lorqu'une methode ne depend ou ne modifie
        /// aucune données de notre pizza on peut la placer en static
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string FormatPremierLettreMajuscule (string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            string nomMinuscules = s.ToLower();
            string nomMajuscule = s.ToUpper();

            string nomAfficher = nomMajuscule[0] + nomMinuscules[1..];

            return nomAfficher;
        }


        /// <summary>
        /// on peut definir une methode bool qui verifie si la liste d'ingredient contient un tel ingredient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        public  bool contientIngredient(string ingredient)
        {
            return ingredients.Where(i => i.ToLower().Contains("tomate")).ToList().Count > 0;
        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


           
           //var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var path = "out";
            Directory.CreateDirectory(path);
            string filename = "monFichier1.txt";
            string pathAndFile = Path.Combine(path, filename);
            

            Console.WriteLine("Fichier ecrit dans " + pathAndFile);
            File.WriteAllLines(pathAndFile, new List<string>() { "Moustafa","Yassine"});

            //Console.WriteLine("Lecture du fichier");

            //if (File.Exists(pathAndFile))
            //{
            //    var result = File.ReadLines(pathAndFile);

            //    foreach (var data in result)
            //    {
            //        Console.WriteLine($" {data} ");
            //    }
            //}else
            //{
            //    Console.WriteLine("Le fichier demande <" + filename + "> n'existe pas");
            //}
         


        }
    }
}
