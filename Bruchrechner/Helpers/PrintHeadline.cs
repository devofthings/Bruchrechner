/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion gibt eine zentrierte Überschrift aus.
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void PrintHeadline(string headline)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (headline.Length / 2)) + "}", headline));
        }
    }
}
