using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_online_Judge_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble( Console.ReadLine());
            double pi = 3.1415;
            double totatl = pi*r * r;
            Console.WriteLine(" A={0:F4}",totatl);
            Console.ReadKey();
        }
    }
}
