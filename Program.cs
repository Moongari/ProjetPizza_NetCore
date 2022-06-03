using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetPizza
{


    public class Pizza
    {
        public string nom { get; set; }
        public float prix { get; private set; }
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
                new Pizza("4 saisons",12f,true,new List<String>(){"mozarella","Tomates","oignons","poivrons" }) ,
                new Pizza("vegetarienne",11.5f, true,new List<String>(){"mozarella","Oeufs","Tomate","Choux" }) ,
                new Pizza("indienne", 14.5f,  false,new List<String>(){"mozarella","Poulet","oignons","Curry","Tomate" } ),
                new Pizza("calzone", 9.5f,false,new List<String>(){"mozarella","Jambon","Tomate","Poulet" } )
            };


            //var pizzxaMoinsCher = listPizza.OrderBy(p => p.prix).ToList();
            //var pizzaPlusCher = listPizza.OrderByDescending(p => p.prix).ToList();

            //foreach (var pizza in pizzxaMoinsCher)
            //{
            //    pizza.afficher();
            //}

            //Console.WriteLine();
            //Console.WriteLine("PIZZA DU PLUS CHER AU MOINS CHER");

            //foreach (var pizza in pizzaPlusCher)
            //{
            //    pizza.afficher();
            //}

            float prixMin = 0;
            float prixMax = 0;
            string pizza = string.Empty;


       


            foreach (var p in listPizza)
            {

                    if(prixMin == 0) { prixMin = p.prix; }
                    if(prixMax == 0) { prixMax = p.prix; }
                    if(prixMin > p.prix) { prixMin = p.prix; pizza = p.nom; }
                    if (prixMax < p.prix) { prixMax = p.prix; pizza = p.nom; }


            }

            Console.WriteLine($"la pizza la moins cher est : {pizza} - {prixMin} €");
            Console.WriteLine($"la pizza la plus cher est : {pizza} - {prixMax} €");


            //liste des pizzas uniquement vegetarienne

            var listPizzaVegetarienne = listPizza.Where(p => p.vegetarienne)
                .Select(p => p.nom).ToList();

            foreach (var item in listPizzaVegetarienne)
            {

                Console.WriteLine($"Pizza veg : {item}");
            }

            // rechercher dans la liste des ingredients toutes les pizzas qui ont de la tomate

            var pizzaContientTomate = listPizza. 
                Where(p=>p.ingredients. // on parcours l'ensemble des pizzas
                Where(i=> i.ToLower().Contains("tomate")).ToList().Count>0) // et on recherche pour chaque ingredient contenu dans une pizza si elle posse de la tomate
                .OrderBy(p=>p.prix).ToList(); // on trie de la moins chere a la plus chere.
            
            Console.WriteLine();
            Console.WriteLine("===liste des pizzas qui contiennent de la Tomate===");
            foreach (var item in pizzaContientTomate)
            {
                Console.WriteLine($"{item.nom} - {item.prix} €");
            }

        }
    }
}
