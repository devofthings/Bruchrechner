/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion erlaubt das multiplizieren von 2 Brüchen.
*/

using System;

namespace Bruchrechner
{
    partial class Program
    {
        public static void Multiplikation(ref int newZaehler, ref int newNenner, int zaehlerOne, int nennerOne, int zaehlerTwo, int nennerTwo)
        {
            newZaehler = zaehlerOne * zaehlerTwo;
            newNenner = nennerOne * nennerTwo;
            Console.WriteLine($"{zaehlerOne}/{nennerOne} * {zaehlerTwo}/{nennerTwo} = {newZaehler}/{newNenner}");
        }
    }
}