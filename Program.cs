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
            string url = "Https://codeavecjonathan.com/res/exemple.html";

            var webClient = new WebClient();
            //appel synchrone
            String reponse = webClient.DownloadString(url);
            Console.WriteLine(reponse);

        }

    }
}
