using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer client1= new Customer();
            client1.City = "Genève";
            client1.Firstname = "Rubén";
            client1.LastName = "Cardozo";

            Customer client2 = new Customer();
            client2.City = "Paris";
            client2.Firstname = "Sébastien";
            client2.LastName = "Pertus";

            //Console.WriteLine(client1.GetCompleteName());
            Console.WriteLine(client2.GetCompleteName());
            Console.Read();
        }
    }
}
