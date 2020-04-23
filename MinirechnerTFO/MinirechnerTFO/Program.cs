using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO
{
    class Program

    {

        // MINIRECHNERTFO

        public static void Main(string[] args)
        {
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Addiere(Zahl1,Zahl2));
            Console.WriteLine(Subtrahiere(Zahl1, Zahl2));
            Console.WriteLine(Multiplizieren(Zahl1, Zahl2));

            Console.ReadKey();
            
        }
        static int Addiere(int Zahl1, int Zahl2)
        {
            int erg = Zahl1 + Zahl2;
            return (erg);
        }
        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            int erg = Zahl1 - Zahl2;
            return (erg);
        }
        static int Multiplizieren(int Zahl1, int Zahl2)
        {
            int erg = Zahl1 * Zahl2;
            return (erg);
        }

     
    }
}
