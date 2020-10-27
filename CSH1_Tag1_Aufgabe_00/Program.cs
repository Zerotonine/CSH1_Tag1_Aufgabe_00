using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag1_Aufgabe_00
{
    class Program
    {
        static uint QSumme(uint zahl)
        {
            if(zahl < 10)
            {
                return zahl;
            }

            uint summe = 0;
            while (zahl > 0)
            {
                summe += zahl % 10;
                zahl = zahl / 10;
            }
            return summe;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Zahl eingeben: ");
            uint iEingabe = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Die Quersumme von {iEingabe} lautet {QSumme(iEingabe)}");
            Console.ReadKey();
        }
    }
}
