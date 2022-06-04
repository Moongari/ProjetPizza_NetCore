using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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


           List<Personne> listpersonne = new List<Personne>() 
            { 
                new Personne() { Name="Alber",age=30},
                new Personne() { Name="Richard",age=23},
                new Personne() { Name="Camille",age=45},
                new Personne() { Name="Delphine",age=32 }
            };

            var json = JsonConvert.SerializeObject(listpersonne);
            var infoPersonne = new StringBuilder();
            infoPersonne.Append(json.ToString());
            var path = "out";
            var filename = "infoPersonne.txt";
            var pathAndFile = Path.Combine(path, filename);

            Console.WriteLine("Sauvegarde des données executées");
           File.WriteAllText(pathAndFile, infoPersonne.ToString());
            Console.WriteLine("Sauvegarde des données Terminées");
            Console.WriteLine(json);

        }
    }
}
