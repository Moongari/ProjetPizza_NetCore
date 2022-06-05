using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace ProgrammeDateTime
{



    // Fonction asynchrone : Delegate ou CallBack

    

    public class Program
    {
        static bool isDownload = false;
      
        static void Main(string[] args)
        {

            //Exemple lors du telechargement d'une image importante
            // 1) version synchrone 
            var url = "https://codeavecjonathan.com/res/bateau.jpg";
            
            var webClient = new WebClient(); 

            //Console.Write("Telechargement en cours...");
            //webClient.DownloadFile(url, "bateau.jpg");
            //Console.Write(" Terminé ");

            // 2) version Asynchrones 

            Console.Write("Telechargement en cours...");
         
            webClient.DownloadFileCompleted += DownloadFileCompleted;
            webClient.DownloadFileAsync(new Uri(url), "bateau.jpg");

           
            while (!isDownload)
            {
                Thread.Sleep(500);
                Console.Write(".");
                
            }


            Console.Write(" Fin du programme ");

        }

        private static void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
            Console.WriteLine("Téléchargement terminé");
            isDownload = true;
        }
    }
}
