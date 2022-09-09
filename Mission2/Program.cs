using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Program
    {
        static void Main()
        {
            Compte c, c1;
            c = new Compte();
            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
            Console.ReadLine();

        }
    }
}
