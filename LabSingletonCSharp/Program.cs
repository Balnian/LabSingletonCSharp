using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabSingletonCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichier = File.OpenText("C:/Users/201250541/Documents/Client_Serveur/LaboSingletons/ListeActeur3.txt");
            List<Acteur> Acteurs = new List<Acteur>(); 
            while (fichier.Peek()>=0)
	        {
                Acteurs.Add(new Acteur(fichier.ReadLine()));
	        }
            Console.WriteLine(Acteur.NbrActeur());

            asd();
            Acteurs.Remove(Acteurs.First());

            Console.WriteLine(Acteur.NbrActeur());
        }

        static private void asd()
        {
            using(Acteur asd = new Acteur("sedf sdf"))
            {
                Console.WriteLine(Acteur.NbrActeur());
            }
            
        }
    }
}
