using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPizza
{
    public class Utiles : IAffichable
    {

        public string filename { get; set; }
        public string path { get; set; }
        public string pathAndFile { get; set; }

        public string description { get; set; }

        public Utiles()
        {
            filename = "log.txt";
            path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            joinPathAndFile();

        }



        public void writeFile (string pathAndFile)
        {

            File.WriteAllText(pathAndFile, description);
        }

        public void ReadFile(string pathAndFile)
        {
            if (File.Exists(pathAndFile))
            {
                File.ReadAllLines(pathAndFile);
            }
            else
            {
                AfficherError();
            }
            
        }



        public  string joinPathAndFile()
        {

            this.pathAndFile = Path.Combine(path, filename);

            return pathAndFile;
        }


    

        public void AfficherMessage(bool isWriteFile = false)
        {

            if (isWriteFile)

            {
                string message = "Ecriture du fichier dans " + pathAndFile;
                Console.WriteLine($" {message} ");
            }
            else
            {
                string message = "Lecture du fichier  a partir de : " + pathAndFile;
                Console.WriteLine($" {message} ");
                Console.WriteLine();
                Console.WriteLine("Lecture Terminée....");
            }
        }

        public void AfficherError()
        {
            if (File.Exists(pathAndFile)){
                string error = $"le fichier {pathAndFile} n'existe pas . ";
            } 
        }
    }

    
}
