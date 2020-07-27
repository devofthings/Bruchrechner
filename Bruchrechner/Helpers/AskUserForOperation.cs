/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion erlaubt den User das Auswählen der gewünschten Operation.
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void AskUserForOperation(ref int operation)
        {
            Console.WriteLine("Wähle die Rechenoperation aus:");
            Console.WriteLine("1) Addieren");
            Console.WriteLine("2) Subtrahieren");
            Console.WriteLine("3) Multiplizieren");
            Console.WriteLine("4) Dividieren");
            CheckAndSetOperation(Console.ReadLine(), ref operation);
        }
    }
}
