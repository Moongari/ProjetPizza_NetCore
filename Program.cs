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

        public void afficher()
        {

          
            string badgeVegetarienne = vegetarienne ?  " (V) " : "";

            Console.WriteLine($" nom : {nom} {badgeVegetarienne} - prix : {prix} € ");
          
                
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var listPizza = new List<Pizza>() { 

                new Pizza() { nom = "4 fromages", prix = 10.5f, vegetarienne = true },
                new Pizza() { nom = "Napolitaine", prix = 13.5f, vegetarienne = false },
                new Pizza() { nom = "4 saisons", prix = 12f, vegetarienne = true },
                new Pizza() { nom = "LA vegetarienne", prix = 11.5f, vegetarienne = true },
                new Pizza() { nom = "Indienne", prix = 14.5f, vegetarienne = false },
                new Pizza() { nom = "Calzone", prix = 9.5f, vegetarienne = false },
            };


            foreach (var pizza in listPizza)
            {
                pizza.afficher();
            }
        }
    }
}
