using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            foreach (string month in months)//pour chaque élément du tableau(déclarer variable month dans le tableau months)
            {
                Console.WriteLine(month);
            }
        }
    }
}
