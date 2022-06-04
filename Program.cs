using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetPizza
{



    class Personne
    {
        public string Name { get; set; }
        public int age { get; set; }


        public void afficher()
        {
            Console.WriteLine($" {Name} -  {age} ans");
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            var personne = new Personne();
            personne.Name = "toto";
            personne.age = 20;

            personne.afficher();


            /* information la serialisation et deserialisation
             se base sur l'accessibilité aux variable
            pour cela il est preferable de definir des getters et setters
            afin que celles ci soient deserialisé car le principe de deserialisation
            se base sur l'accessibilité des variables si celles si sont private , ce ne sera pas possible
            Ou prevoir un constructeur dans la classe qui rappel ces memes variables

            la serialisation elle se base sur get de la variable 
            */

            //serialisation de l'objet Personne
            var json = JsonConvert.SerializeObject(personne);
            Console.WriteLine(json);

            //deserialisation d'un fichier json 
            string jsonJohn = "{\"Name\":\"john\",\"age\":34}";
            Personne person = JsonConvert.DeserializeObject<Personne>(jsonJohn);
            person.afficher();
        
        }
    }
}
