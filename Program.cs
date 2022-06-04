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
