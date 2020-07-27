/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion gibt das endgültige gekürzte Resultat aus.
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void PrintResult(ref int newZaehler, ref int newNenner, ref int ggT)
        {
            Console.WriteLine($"Gekürztes Ergebnis: {newZaehler / ggT}/{newNenner / ggT}");
        }
    }
}
