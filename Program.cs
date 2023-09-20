using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;
namespace Warm_oder_Kalt;

internal class Program
{
    static void Main(string[] args)
    {
        // Programmieren Sie das Spiel Warm oder Kalt.
        //
        // - Der Computer soll eine zufällige zahl zwischen 0 und 100 auswählen.
        // - Anschließend wenn die Runde gestartet wird soll der Spieler seinen Namen eingeben können.
        // - Dann sollen sie durch Eingabe von Zahlen versuchen den Wert zu ermitteln.
        // - Bei der ersten Eingabe kommt keine Meldung.
        // - Ab der zweiten soll angezeigt werden ob sie dem gesuchten Wert näher kommen(Wärmer), oder sich davon entfernen (Kälter).
        // - Wenn die Gesuchte Zahl gefunden ist sollen die benötigten Züge zusammen mit dem namen des Spielers angezeigt  werden.
        // - Ebenso soll eine Liste mit allen Highscores angelegt werden, die Gespeichert und auch geladen werden kann.
        // - Diese Liste soll mit dem ersten Platz starten, also den wenigsten versuchen.

        // * Das Spiel soll neben der Program.cs auch die Klassen Spieler mit name, score und einer Liste der Spieler beinhalen
        // * Sowie der Klasse Spiel für die Spiellogik,
        // * Der Klasse Menue mit einem Menü das als Startmethode fungiert,
        // * Und der Klasse Serialisierung die sich um Methoden zum Speichern und laden der Daten dreht.

        Menue.Start();
    }
}