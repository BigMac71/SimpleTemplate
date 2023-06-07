using System.Xml.Serialization;

namespace SimpleTemplate
{
    /* het eerste en belangrijkste bestand van je project is Program.cs
     * deze bevat de klasse 'Program' */
    internal class Program
    {
        /* We declareren en initialiseren enkele properties van de klasse Program.
         * dit zijn dus instanties (objecten) van de andere klassen uit de folders Presentation, Logic en Persistance 
         * die we hier zullen nodig hebben.
         */


        /* de belangrijkste (en vaak enige) functie van de klasse 'Program' is Main()
         * dit is het entry-point van je programma,
         * m.a.w. als je het programma start, wordt deze functie uitgevoerd 
         * 
         * Visual Studio geeft Main standaard een array van argumenten mee
         * dit omdat je op die manier commandline argumenten kan gebruiken 
         * als je het programma start vanuit de console (CLI).
         * Wij hebben dat nooit gedaan, maar zo weet je dat het kan.
         * Ik zal ze hier ter illustratie laten staan, maar niet gebruiken
         * 
         * Deze functie bevat in heel grote lijnen wat je programma doet.
         * In onze kleine oefeningen zal dat meestal niet veel meer zijn dan bijvoorbeeld:
         * 1. de console leegmaken --> method van een klasse in presentatielaag aanroepen
         * 2. een menu tonen --> method van een klasse in presentatielaag aanroepen
         * 3. de gebruiker vragen om een keuze te maken uit het getoonde menu --> presentatie
         * 4. input vragen van de gebruiken op basis van het gekozen menu item --> presentatie
         * 5. iets doen/berekenen op basis van de gemaakte keuze en de ingevoerde data --> logic/persistence
         * 6. het resultaat hiervan eventueel formatteren (sorteren ofzo) en laten zien op het scherm --> logic/presentatie
         */
        static void Main(string[] args)
        {
            do
            {
                
            } while (choice != 'X');
        }
    }
}