using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_og_Datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = 16;
            double width = 5.1;

            int Area = lenght * width;
            double d = lenght * width;

            Console.WriteLine(Area.ToString());
            Console.ReadLine();

            // I opgave B kører koden ikke, fordi den ikke kan konventere en int til en double

            // I opgave C kører koden, fordi den godt kan konventere en int til en double
        }
    }
}
