using System;
using System.Collections.Generic;

namespace ProjetPizza
{


    public class Pizza
    {
        public string nom { get; set; }
        public float prix { get; set; }
        public bool vegetarienne = false;
        public List<String> ingredients;

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
           
            Console.WriteLine(String.Join(",", ingredients));
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

     
        

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //List<String> ingredients = new List<string>() { "mozarella", "Poulet", "oignon", "cantal", "gruyere", "Comte", "poivrons" };

            var listPizza = new List<Pizza>() {

                new Pizza("4 fromages",10.5f,true,new List<String>(){"mozarella","Comte","Camembert","Cheddar" }) ,
                new Pizza("napolitaine",13.5f,false,new List<String>(){"mozarella","Comte","Tomate" }),
                new Pizza("4 saisons",12f,true,new List<String>(){"mozarella","Tomate","oignons","poivrons" }) ,
                new Pizza("vegetarienne",11.5f, true,new List<String>(){"mozarella","Oeufs","Tomate","Choux" }) ,
                new Pizza("indienne", 14.5f,  false,new List<String>(){"mozarella","Poulet","oignons","Curry","Tomate" } ),
                new Pizza("calzone", 9.5f,false,new List<String>(){"mozarella","Jambon","Tomate","Poulet" } )
            };


            foreach (var pizza in listPizza)
            {
                pizza.afficher();
            }
        }
    }
}
