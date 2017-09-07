using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quackers
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Brian Fortuin";

            Console.WriteLine(name);
            Console.WriteLine(name.Quack());



        }

        
    }

    public static class Extensions //NOthe that this is static
    {
        public static string Quack(this string self)
        {
            return self + " (quack)";
        }

    }
}
