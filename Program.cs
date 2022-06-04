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


            //var personne = new Personne();
            //personne.Name = "Billy";
            //personne.age = 45;

            //personne.afficher();


            ///* information la serialisation et deserialisation
            // se base sur l'accessibilité aux variable
            //pour cela il est preferable de definir des getters et setters
            //afin que celles ci soient deserialisé car le principe de deserialisation
            //se base sur l'accessibilité des variables si celles si sont private , ce ne sera pas possible
            //Ou prevoir un constructeur dans la classe qui rappel ces memes variables

            //la serialisation elle se base sur get de la variable 
            //*/

            ////serialisation de l'objet Personne
            //var json = JsonConvert.SerializeObject(personne);
            //Console.WriteLine(json);

          

            //Console.WriteLine("Sauvegarde des données executées");
            //File.WriteAllText(pathAndFile, infoPersonne.ToString());
            //Console.WriteLine("Sauvegarde des données Terminées");


            ////deserialisation d'un fichier json 
            //var jsonlist = File.ReadAllLines(pathAndFile);

            //foreach (var item in jsonlist)
            //{
            //    Personne person = JsonConvert.DeserializeObject<Personne>(item);
            //    person.afficher();
            //}
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
