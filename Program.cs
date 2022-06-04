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
            string url = "Https://codeavec_jonathan.com/res/pizzas1.json";
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
                if(ex.Response != null)
                {
                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;

                    Console.WriteLine($" - Page non trouve :  {statusCode} - "); ;
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
           

        }

    }
}
