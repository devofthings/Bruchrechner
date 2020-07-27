/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion erlaubt das subtrahieren von 2 Brüchen.
*/

using System;

namespace Bruchrechner
{
    partial class Program
    {
        public static void Subtraktion(ref int newZaehler, ref int newNenner, int zaehlerOne, int nennerOne, int zaehlerTwo, int nennerTwo)
        {
            newZaehler = (zaehlerOne * nennerTwo) - (zaehlerTwo * nennerOne);
            newNenner = nennerOne * nennerTwo;
            Console.WriteLine($"{zaehlerOne}/{nennerOne} - {zaehlerTwo}/{nennerTwo} = {newZaehler}/{newNenner}");
        }
    }
}