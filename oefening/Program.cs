using System;
using System.Linq;

namespace First
{
    class Program
    {

        //Algemene opmerking: kijk bij het uitwerken van deze oefeningen steeds na of de System.String class geen method
        //heeft die gebruikt kan worden bij het oplossen van de oefening!


        /* Schrijf een functie die twee opgegeven strings vergelijkt. Indien de strings identiek zijn (ook wat hoofd/kleine
         * letters betreft), dan geef je 'Identiek' als functieresultaat. Zijn de strings verschillend dan is het functieresultaat 
         * 'Verschillend'. Zijn de strings gelijk, maar verschillen ze op gebied van hoofdletters of kleine letters, dan 
         * geef je 'Verschil letters' als resultaat . !!!!String.Equals() !!!!
        */

        public static string VergelijkStrings(string s1, string s2)
        {
            // schrijf hier je code
            return "";
        }

        /* Schrijf een functie die nagaat of een opgegeven woord in de tweede string voorkomt. Als resultaat geef je
         * true (het woord komt in de string voor) of false (het woord komt niet in de string voor).
        */

        public static bool ZoekWoord(string woord, string zin)
        {
            // schrijf hier je code
            return true;
        }

        /* Schrijf een functie die telt hoeveel keer een opgegeven letter voorkomt in een opgegeven zin.
        */

        static public int TelLetter(char letter, string zin)
        {
            // schrijf hier je code
            return 0;
        }


        /* Schrijf een functie die de klinkers in een opgegeven zin vervangt door een * en de aangepaste zin als 
         * functieresultaat geeft. !!!!String.Replace()!!!!
         */

        public static string VeranderKlinkers(string zin)
        {
            // schrijf hier je code
            return "";
        }

        /* Schrijf een functie die telt hoeveel karakters een string bevat, nadat de overtollige spaties in het begin en
         * het einde verwijderd zijn. Geef het aantal karakters als functieresultaat. !!!!Trim()!!!!
        */
        public static int TelKarakters(string zin)
        {
            // schrijf hier je code
            return 0;
        }

        /* Schrijf een functie die het langste woord in een opgegeven zin zoekt en dit woord als functieresultaat geeft.
         * Indien er meerdere woorden dezelfde lengte hebben, geef je één van deze woorden als resultaat.
        */
        public static string ZoekLangsteWoord(string zin)
        {
            // schrijf hier je code
            return "";
        }

        /* Ontwerp een consoletoepassing waarmee je een Belgisch ondernemingsnummer kan controleren. 
         * Een Belgisch ondernemingsnummer is als volgt opgebouwd: BE 0xxx.xxx.xxx waarbij BE de landcode is die standaard gevolgd
         * wordt door een spatie en dan een 0. Wanneer je de volgende 7 cijfers deelt door 97 in een gehele deling, dan is het 
         * getal gevormd door de laatste 2 cijfers gelijk aan 97 minus de rest van deze gehele deling. 
         * Een ongeldig ondernemingsnummer genereert 'true' als functieresultaat, een ongeldig 'false'.
        */
        public static bool ControleerOndNr(string ondNr)
        {
            // schrijf hier je code
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Naam oefening \t\t Verwacht resultaat \t\t Jouw resultaat");
            Console.WriteLine("VergelijkStrings \t Verschillend \t\t\t " + VergelijkStrings("Water", "Wind"));
            Console.WriteLine("VergelijkStrings \t Identiek \t\t\t " + VergelijkStrings("Water", "Water"));
            Console.WriteLine("VergelijkStrings \t Verschil letters \t\t " + VergelijkStrings("Water", "water"));
            Console.WriteLine("ZoekWoord \t\t True \t\t\t\t " + ZoekWoord("processor", "geheugen toetsenbord processor scherm"));
            Console.WriteLine("ZoekWoord \t\t False \t\t\t\t " + ZoekWoord("processor", "geheugen toetsenbord voeding scherm"));
            Console.WriteLine("TelLetter \t\t 4 \t\t\t\t " + TelLetter('a', "Computers zijn handige apparaten."));
            Console.WriteLine("TelLetter \t\t 0 \t\t\t\t " + TelLetter('u', "Deze zin bevat de letter niet."));
            Console.WriteLine("VeranderKlinkers \t D*z* z*n b*v*t g**n kl*nk*rs. \t " + VeranderKlinkers("Deze zin bevat geen klinkers."));
            Console.WriteLine("TelKarakters \t\t 18 \t\t\t\t " + TelKarakters("   Dit is de testzin.    "));
            Console.WriteLine("ZoekLangsteWoord \t aangekomen \t\t\t " + ZoekLangsteWoord("De nieuwe computers zijn aangekomen op school."));
            Console.WriteLine("ControleerOndNr \t True \t\t\t\t " + ControleerOndNr("BE 0425.989.356"));
            Console.WriteLine("ControleerOndNr \t False \t\t\t\t " + ControleerOndNr("BE 0425.989.355"));
            Console.ReadKey();
        }
    }
}
