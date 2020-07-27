/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion prüft ob der User eine Wahl zwischen 1 und 4 trifft und setzt dann den Operations Wert.
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void CheckAndSetOperation(string valueToParse, ref int valueToSet)
        {
            bool isChecked = false;
            int number;
            bool userIsStupid = true;

            while (isChecked == false)
            {
                bool success = Int32.TryParse(valueToParse, out number);
                if (success)
                {
                    if (number > 0 && number <= 4)
                    {
                        // Setze Wert
                        valueToSet = number;
                        isChecked = true;
                    }
                    else
                    {
                        while (userIsStupid)
                        {
                            Console.WriteLine("Bitte gebe eine Zahl zwischen 1 und 4 ein.");
                            Console.Write("Neuer Wert: ");
                            success = Int32.TryParse(Console.ReadLine(), out number);
                            if (success)
                            {
                                if (number > 0 && number <= 4)
                                {
                                    // Setze Wert
                                    valueToSet = number;
                                    userIsStupid = false;
                                    isChecked = true;
                                }
                                else
                                {
                                    // Unnötiges true aber die Betonung der Dummheit ist hier angebracht
                                    userIsStupid = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    while (userIsStupid)
                    {
                        Console.WriteLine("Bitte gebe eine Zahl zwischen 1 und 4 ein.");
                        Console.Write("Neuer Wert: ");
                        success = Int32.TryParse(Console.ReadLine(), out number);
                        if (success)
                        {
                            if (number > 0 && number <= 4)
                            {
                                // Setze Wert
                                valueToSet = number;
                                userIsStupid = false;
                                isChecked = true;
                            }
                            else
                            {
                                // Unnötiges true aber die Betonung der Dummheit ist hier angebracht
                                userIsStupid = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
