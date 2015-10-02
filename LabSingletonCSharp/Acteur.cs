using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSingletonCSharp
{
    public class Acteur:IDisposable
    {
        private static int cptAct = 0;
        public string nom { get; private set; }
        public string prenom { get; private set; }

        public Acteur(string nom)
        {
            this.nom = nom.Trim().Split(' ')[0];
            this.prenom = nom.Trim().Split(' ')[1];
            cptAct++;
        }

        public static int NbrActeur() 
        {
            return cptAct;
        }

        public Acteur(Acteur act)
        {
            cptAct++;
        }

        public void Dispose()
        {
            cptAct--;
            //Dispose(true);
        }
       
    }
}
