/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion gibt den ggT aus und reicht den Wert nach "oben" weiter.
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void PrintGGT(ref int newZaehler, ref int newNenner, ref int ggT)
        {
            ggT = Euklid(newZaehler, newNenner);
            Console.WriteLine($"ggT: {ggT}");
        }
    }
}
