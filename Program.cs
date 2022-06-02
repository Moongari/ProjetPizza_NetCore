using System;
using System.Collections.Generic;

namespace ProjetPizza
{


    public class Pizza
    {
        public string nom { get; set; }
        public float prix { get; set; }
        public bool vegetarienne = false;

        public Pizza()
        {
         
        }

        public Pizza(string nom, float prix,bool vegetarienne)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
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

            // on aurait pu faire egalement 
            string nomAfficher = FormatPremierLettreMajuscule(nom);

            Console.WriteLine($" nom : {nomAfficher} {badgeVegetarienne} - prix : {prix} € ");
          
                
        }

        /// <summary>
        /// Lorqu'une methode ne depend ou ne modifie
        /// aucune données de notre pizza on peut la placer en static
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string FormatPremierLettreMajuscule (string s)
        {
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

            var listPizza = new List<Pizza>() { 

                new Pizza() { nom = "4 fromages", prix = 10.5f, vegetarienne = true },
                new Pizza() { nom = "napolitaine", prix = 13.5f, vegetarienne = false },
                new Pizza() { nom = "4 saisons", prix = 12f, vegetarienne = true },
                new Pizza() { nom = "vegetarienne", prix = 11.5f, vegetarienne = true },
                new Pizza() { nom = "indienne", prix = 14.5f, vegetarienne = false },
                new Pizza() { nom = "calzone", prix = 9.5f, vegetarienne = false },
            };


            foreach (var pizza in listPizza)
            {
                pizza.afficher();
            }
        }
    }
}
