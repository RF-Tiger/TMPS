using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            TheBell s1 = TheBell.Instance();
            TheBell s2 = TheBell.Instance();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            Console.ReadKey();
        }
    }
}
