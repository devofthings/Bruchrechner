/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese Funktion prüft ob der User eine Zahl die größer als 0 ist für die Brüche eingegeben hat, anschließend wird diese gesetzt.
*/

using System;
namespace Bruchrechner
{
    partial class Program
    {
        public static void CheckAndSetZaehlerOrNenner(string valueToParse, ref int valueToSet)
        {
            bool isChecked = false;
            int number;
            bool userIsStupid = true;

            while(isChecked == false)
            {
                bool success = Int32.TryParse(valueToParse, out number);
                if (success)
                {
                    if (number > 0)
                    {
                        // Setze Wert von Zaehler oder Nenner
                        valueToSet = number;
                        isChecked = true;
                    }
                    else
                    {
                        while (userIsStupid)
                        {
                            Console.WriteLine("Bitte nutze nur ganze Zahlen größer als 0.");
                            Console.Write("Neuer Wert: ");
                            success = Int32.TryParse(Console.ReadLine(), out number);
                            if (success)
                            {
                                if (number > 0)
                                {
                                    // Setze Wert von Zaehler oder Nenner
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
                        Console.WriteLine("Bitte nutze nur ganze Zahlen größer als 0.");
                        Console.Write("Neuer Wert: ");
                        success = Int32.TryParse(Console.ReadLine(), out number);
                        if (success)
                        {
                            if (number > 0)
                            {
                                // Setze Wert von Zaehler oder Nenner
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
