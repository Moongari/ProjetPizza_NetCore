using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammeDateTime
{



    // Fonction asynchrone : Async /await

    

    public class Program
    {
       
      
        static async Task Main(string[] args)
        {
            string url1 = "https://codeavecjonathan.com/res/dummy.txt";
            string url2 = "https://codeavecjonathan.com/res/pizzas1.json";

            Console.WriteLine("Téléchargement.....");
            var displayTask = infoTelechargement();
            var task1 = downLoadData(url1);
            var task2 = downLoadData(url2);

            await task1;
            await task2;
            Console.WriteLine("Fin du programme");
        }




        //Task correspond a une methode void il est preferable d'utiliser Task que void
        // si l'on desire renvoye une valeur on utilisera Task<String> avec un return dans la methode.
        static async Task downLoadData(string url)
        {
            

            try
            {
                var httpClient = new HttpClient();
                var resultat = await httpClient.GetStringAsync(url);
            }
            catch (HttpRequestException ex)
            {
                var statusCode = ex.StatusCode;
                //Console.WriteLine("probleme de telechargement" + ex);
                Console.WriteLine("Erreur " + statusCode);
            }
            

            //Console.WriteLine($"{resultat}");
            Console.WriteLine("ok =>"+url);
        }


        static async Task infoTelechargement()
        {
            string info = ".";
            while (true)
            {
                await Task.Delay(500);
                Console.Write(info);
            }
        }
        
    }
}
