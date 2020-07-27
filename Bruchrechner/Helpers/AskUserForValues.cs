/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion erlaubt dem User die Eingabe der Werte der Brüche. 
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void AskUserForValues(ref int zaehlerOne, ref int nennerOne, ref int zaehlerTwo, ref int nennerTwo)
        {
            Console.WriteLine("1. Bruch");
            Console.Write("Gebe den Zähler an: ");
            CheckAndSetZaehlerOrNenner(Console.ReadLine(), ref zaehlerOne);
            Console.Write("Gebe den Nenner an: ");
            CheckAndSetZaehlerOrNenner(Console.ReadLine(), ref nennerOne);
            Console.WriteLine("2. Bruch");
            Console.Write("Gebe den Zähler an: ");
            CheckAndSetZaehlerOrNenner(Console.ReadLine(), ref zaehlerTwo);
            Console.Write("Gebe den Nenner an: ");
            CheckAndSetZaehlerOrNenner(Console.ReadLine(), ref nennerTwo);
        }
    }
}
