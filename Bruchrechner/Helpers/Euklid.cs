/*
 * Author: Christopher Winter 
 * Klasse: IA119
 * Datum: 27.07.2020
 * Beschreibung: Diese rekursive Funktion erlaubt das finden des ggT (größten gemeinsamen Teilers) von 2 Integer Werten.
*/

namespace Bruchrechner
{
    partial class Program
    {
        public static int Euklid(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Euklid(b, a % b);

        }
    }
}
