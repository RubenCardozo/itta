using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[7];
            Random aleatoire = new Random();
            
            for (int i = 0; i < tableau.Length; i++)
            {

                    int numLotto = aleatoire.Next(0, 49);
                    tableau[i] = numLotto;
                    Console.WriteLine(tableau[i]);
   
            }
            
            Console.ReadLine();

        }
    }
}
