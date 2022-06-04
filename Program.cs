using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProgrammeDateTime
{





    

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // demarrage sur de nouvelles fonctionnalite a connaitre

            //DateTime
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            CultureInfo cultureUs = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine(date.ToString("dd/MM/yyyy"), cultureUs);
         
         


        }
    }
}
