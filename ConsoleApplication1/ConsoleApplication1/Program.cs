using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //String myString = "Bonjour à tous pour ce nouveau module";
            //String myString = "c:\temp\monfichier.txt";
            DateTime myDate = DateTime.Now;

            String myString = String.Format("Nous sommes le {0:D}", myDate);

            Console.WriteLine(myString.ToString());

            Console.ReadLine();
        }
    }
}
