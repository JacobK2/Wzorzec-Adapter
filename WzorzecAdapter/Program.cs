using System;
using System.Collections.Generic;

namespace WzorzecAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter");
            Console.WriteLine("Wykonanie:");
            List<AktualneZadanie> zad = new List<AktualneZadanie>()
            {
                new AktualneZadanie(),
                new Adapter()
            };

            foreach(AktualneZadanie z in zad)
            {
                z.info();
            }
            Console.WriteLine("Zakończenie programu.");
            Console.ReadKey();
        }
    }
}
