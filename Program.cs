

global using Newtonsoft.Json; // utilisation d'un global using
// permet de le rendre disponible sur l'ensemble des classes du projet.
using ProgrammeDateTime;

Console.WriteLine("Hello C#10 .NET 6");

var p = new Personne() { name = "Toto", infoPer = 4 };

var json = JsonConvert.SerializeObject(p);
Console.WriteLine(json);