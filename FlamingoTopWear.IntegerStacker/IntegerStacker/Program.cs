using System;
using System.Collections.Generic;

namespace FlamingoTopWear.IntegerStacker
{
    public class Program
    {

        static void Main(string[] args)
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(0);
            x.Push(5);
            x.Divide();
            var g = x.Top();
            Console.WriteLine(g);
            Console.ReadLine();
        }
    }
}
