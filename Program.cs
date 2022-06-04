using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ProjetPizza
{







    public class Program
    {
        static void Main(string[] args)
        {
            // Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Programme_ Reseau
            string url = "Https://codeavecjonathan.com/res/pizzas1.json";
            string url2 = "Https://codeavecjonathan.com/res/papillon.jpg";
            var webClient = new WebClient();
            //appel synchrone
            try
            {
                String reponse = webClient.DownloadString(url);
                Console.WriteLine(reponse);
                webClient.DownloadFile(url2, "papillon.jpg");
                Console.WriteLine("Telechargement terminé");


            }
            catch (WebException ex)
            {
                var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                
                Console.WriteLine($" - Page non trouve :  {statusCode} - "); ;
            }
           

        }

    }
}
