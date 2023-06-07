using SimpleTemplate.Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplate.Logic
{
    internal class LogicManager
    {
        /* We declareren 2 properties in deze klasse.
         * we gebruiken de verkorte notatie met een indicatie naar hun getter en setter.
         * een getter is een simpele method die de waarde van een property opvraagt.
         * een setter is een simpele functie die een waarde toekent aan een property.
         * 
         * Voor deze verkorte notatie zijn er enkele afspraken:
         * 1. altijd public
         * 2. propertynaam begint met een hoofdletter.
         * Dit omdat dit op de achtergrond, tijdens het compileren, 
         * zal omgezet worden naar een private property en een bijhorenden public setter en getter 
         * voor elke property die op deze manier wordt gedeclareerd.
         * 
         * Merk op dat er een vraagteken staat achter het type (string).
         * Dit omdat de waarde van deze properties null kan zijn.
         * Immers, in de standaard constructor wordt aan deze properties geen waarde gegeven.
         * Dat is een keuze en zal in elk programma anders zijn, afhankelijk van de behoeften.
         */
        public string? Property1 { get; set; }
        public string? Property2 { get; set; }

        /* Vaak zullen er in de business logica code ook objecten moeten gebruikt worden 
         * van de verschillende entiteiten die het programma kent (zie Entity1 voor uitleg over entiteiten)
         * Merk op dat er een derde versie van de constructor is, die niet alleen Property1 en Property2, 
         * maar ook deze twee properties, nl. EersteEntiteit and TweedeEntiteit een waarde toekent.
         */
        public Entity1? EersteEntiteit;
        public Entity2? TweedeEntiteit;

        /* Dit is de standaard constructor voor deze klasse,
         * m.a.w. deze functie wordt automatisch aangeroepen als je een nieuw object (instantie) van deze klasse maakt
         * via new()
         */
        public LogicManager() { }
        
        /* Soms zijn er meerdere consturctors die elk een verschillende signature (aantal en type van argumenten) hebben.
         * Dit heet 'overloading'
         * hier een 2e constructor die één string argument heeft.
         * Dus afhankelijk van hoe een object van deze klasse wordt aangemaakt, wordt één van deze constructors gebruikt.
         * vb. LogicManager mgr1 = new() --> hier wordt de standaard constructor aangereoepen om een object te maken.
         * vb. LogicManager mgr2 = new('text') --> hier wordt de andere constructor gebruikt
         * 
         * Merk op dat in deze constructor de 2 properties van de klasse wél een waarde toegekend wordt.
         * 
         * Merk ook op dat we telkens this.xxxx gebruiken.
         * Dit om duidelijk te maken dat het hier gaat om een property van deze klasse
         * Omdat er eigenlijk geen verwarring kan zijn, mag je dit weglaten.
         * Maar wij laten het hier staan voor de duidelijkheid.
         */
        public LogicManager(string name1, string name2)
        {
            this.Property1 = name1;
            this.Property2 = name2;
        }

        public LogicManager(string name1, string name2, Entity1 entiteit1, Entity2 entiteit2)
        {
            this.Property1 = name1;
            this.Property2 = name2;
            this.EersteEntiteit = entiteit1;
            this.TweedeEntiteit = entiteit2;
        }

        /* hier wordt er iets gedaan zonder dat er een returnwaarde verwacht wordt
         * bijvoorbeeld, de waarden van Property1 en Property2 worden verwisseld.
         * 
         * Visual Studio zal - terecht - opmerken dat je beter een Tuple kan gebruiken om waarden om te wisselen, 
         * maar voor de duidelijkheid laten we het hier zo staan.
         */
        public void SwapPropertyValues() 
        {
            string? temp = this.Property1;
            this.Property1 = this.Property2;
            this.Property2 = temp;
        }

    }
}
