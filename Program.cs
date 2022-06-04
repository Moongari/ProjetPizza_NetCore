using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProgrammeDateTime
{





    

    public class Program
    {
        public delegate string validationChaine(string s);
      
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // demarrage sur de nouvelles fonctionnalite a connaitre

            //Delegate
            string nom = DemanderInformationUtilisateur("Indiquer votre nom ?", CheckValidationNom);
            string telephone = DemanderInformationUtilisateur("Indiquer votre numero de telephone ?", CheckValidationTel);

            Console.WriteLine($"Bonjour {nom} - votre numéro de telephone est le {telephone}");

        }

        static string DemanderInformationUtilisateur(string message, validationChaine validation = null)
        {
            Console.WriteLine(message);
            string reponse = Console.ReadLine();
            if(validation != null)
            {
                string erreur = validation(reponse);
                if(erreur != null)
                {
                    Console.WriteLine("Erreur : " + erreur);
                    return DemanderInformationUtilisateur(message, validation);
                }
            }

            return reponse;
        }

        static string CheckValidationNom(string s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                return "le nom ne peut etre vide";
            }

            if (s.Any(char.IsDigit))
            {
                return "le nom ne peut pas contenir de chiffre";
            }



            return null;
        }
        static string CheckValidationTel(string s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                return "le numero de tel  ne peut etre vide";
            }

            if (!s.All(char.IsDigit))
            {
                return "le numero de tel  ne peut  contenir de chiffres";
            }



            return null;
        }
    }
}
