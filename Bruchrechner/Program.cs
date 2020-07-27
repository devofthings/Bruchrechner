/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Dieses Programm erlaubt das berechnen von 2 Bruchwerten mit allen 4 Grundoperationen (+,-,*,/)
*/

using System;

namespace Bruchrechner
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Inititalisierung der Variablen
            // 1. Bruch
            int zaehlerOne = 0;
            int nennerOne = 0;
            // 2. Bruch
            int zaehlerTwo = 0;
            int nennerTwo = 0;
            // Wahl der Operation
            int operation = 0;
            // Neu zu berechnender Bruch
            int newZaehler = 0;
            int newNenner = 0;
            int ggT = 0;
            // Abfolge des Programms
            PrintHeadline("Bruchrechner");
            AskUserForValues(ref zaehlerOne, ref nennerOne, ref zaehlerTwo, ref nennerTwo);
            AskUserForOperation(ref operation);
            switch (operation)
            {
                case 1:
                    Addition(ref newZaehler, ref newNenner, zaehlerOne, nennerOne, zaehlerTwo, nennerTwo);
                    PrintGGT(ref newZaehler, ref newNenner, ref ggT);
                    PrintResult(ref newZaehler, ref newNenner, ref ggT);
                    break;
                case 2:
                    Subtraktion(ref newZaehler, ref newNenner, zaehlerOne, nennerOne, zaehlerTwo, nennerTwo);
                    PrintGGT(ref newZaehler, ref newNenner, ref ggT);
                    PrintResult(ref newZaehler, ref newNenner, ref ggT);
                    break;
                case 3:
                    Multiplikation(ref newZaehler, ref newNenner, zaehlerOne, nennerOne, zaehlerTwo, nennerTwo);
                    PrintGGT(ref newZaehler, ref newNenner, ref ggT);
                    PrintResult(ref newZaehler, ref newNenner, ref ggT);
                    break;
                case 4:
                    Division(ref newZaehler, ref newNenner, zaehlerOne, nennerOne, zaehlerTwo, nennerTwo);
                    PrintGGT(ref newZaehler, ref newNenner, ref ggT);
                    PrintResult(ref newZaehler, ref newNenner, ref ggT);
                    break;
                default:
                    Console.WriteLine("Error: Could not find the wished operation.");
                    break;
            }
            return;
        }
    }
}
