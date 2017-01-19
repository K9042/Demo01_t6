using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh6
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka, litra, hinta;

            Console.Write("Anna ajettu matka: ");
            matka = double.Parse(Console.ReadLine());

            litra = matka / 100 * 7.02;
            hinta = litra * 1.595;

            Console.WriteLine("Bensaa kuluu " + litra);
            Console.WriteLine("Kustannus " + hinta);

        }
    }
}
