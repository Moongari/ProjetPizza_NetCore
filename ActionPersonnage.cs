using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeDateTime
{
    public class ActionPersonnage
    {
        // on definit un delegate qui repond a la signature des methodes 
        // dans l'objet personne.
        public delegate void ActionPersonneHandler (Personne person);

        //on passe notre delegate en parametre de la methode actionPerso
        public void actionPerso(string name,int info,ActionPersonneHandler personHandler)
        {
            // on crée un objet Personne 
            var perso = new Personne() { name = name ,infoPer= info};
            //on delegue l'action
            personHandler(perso);

        }



    }
}
