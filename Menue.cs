using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_oder_Kalt;

internal class Menue
{
    public static void Start()
    {
        while (true)
        {
            bool checkInt;
            bool repeatAuswahl;
            int auswahlReady;
            int auswahlMenue;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\r\n.-.  .-.   .--.   .---.  .-.  .-.      .---.  .----.  .----. .---.      .-..-.   .--.   .-.    .-----. \r\n| {  } |  / {} \\  } }}_} }  \\/  {     / {-. \\ } {-. \\ } |__} } }}_}     | ' /   / {} \\  } |    `-' '-' \r\n{  /\\  } /  /\\  \\ | } \\  | {  } |     \\ '-} / } '-} / } '__} | } \\      | . \\  /  /\\  \\ } '--.   } {   \r\n`-'  `-' `-'  `-' `-'-'  `-'  `-'      `---'  `----'  `----' `-'-'      `-'`-` `-'  `-' `----'   `-'   \r\n                                                                                                       \r\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n(1)Spiel starten\n(2)Highscores zeigen\n(3)Highscores speichern\n(4)Highscores laden\n(5)Spiel beenden");
                checkInt = int.TryParse(Console.ReadLine(), out auswahlMenue);
            } while (checkInt == false);

            if (auswahlMenue == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ACHTUNG: Falls du deine Highscores-Liste noch nicht geladen hast, empfehle ich dir, dies zuerst zu tun, da du andernfalls die Speicherdatei überschreiben musst, wenn du deinen Score speichern möchtest.");
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nBist du bereit, das Spiel zu spielen, oder möchtest du ins Menü zurückkehren?\n\n(1)Spiel starten\n(2)Zurück im Menü");
                    repeatAuswahl = false;
                    do
                    {
                        checkInt = int.TryParse(Console.ReadLine(), out auswahlReady);
                    } while (checkInt == false);
                    
                    if (auswahlReady == 1)
                    {
                        Spiel.Play();
                    }
                    else if (auswahlReady != 1 && auswahlReady != 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ungültige Zahlenauswahl. Drücke ENTER, um es noch einmal zu versuchen.");
                        Console.ReadLine();
                        repeatAuswahl = true;
                    }

                } while (repeatAuswahl == true);
            }
            else if (auswahlMenue == 2)
            {
                    Serialisierung.Ausgabe();
            }
            else if (auswahlMenue == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ACHTUNG: Falls du deine Highscores-Liste noch nicht geladen hast, empfehle ich dir, dies zuerst zu tun, da du andernfalls die Speicherdatei überschreiben wirst.");
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nBist du bereit, deine Highscores-Liste zu speichern, oder möchtest du ins Menü zurückkehren?\n\n(1)Highscores-Liste speichern\n(2)Zurück im Menü");
                    repeatAuswahl = false;
                    do
                    {
                        checkInt = int.TryParse(Console.ReadLine(), out auswahlReady);
                    } while (checkInt == false);

                    if (auswahlReady == 1)
                    {
                        Serialisierung.Speichern();
                    }
                    else if (auswahlReady != 1 && auswahlReady != 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ungültige Zahlenauswahl. Drücke ENTER, um es noch einmal zu versuchen.");
                        Console.ReadLine();
                        repeatAuswahl = true;
                    }

                } while (repeatAuswahl == true);
            }
            else if (auswahlMenue == 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ACHTUNG: Falls du deine Highscore-Liste noch nicht gespeichert hast, empfehle ich dir, dies zuerst zu tun, da du andernfalls die aktuelle Highscores überschreiben wirst.");
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nBist du bereit, deine Highscores-Liste zu laden, oder möchtest du ins Menü zurückkehren?\n\n(1)Highscores-Liste laden\n(2)Zurück im Menü");
                    repeatAuswahl = false;
                    do
                    {
                        checkInt = int.TryParse(Console.ReadLine(), out auswahlReady);
                    } while (checkInt == false);

                    if (auswahlReady == 1)
                    {
                        Serialisierung.Laden();
                    }
                    else if (auswahlReady != 1 && auswahlReady != 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ungültige Zahlenauswahl. Drücke ENTER, um es noch einmal zu versuchen.");
                        Console.ReadLine();
                        repeatAuswahl = true;
                    }

                } while (repeatAuswahl == true);
            }
            else if (auswahlMenue == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ungültige Zahlenauswahl. Drücke ENTER, um ins Menü zurückzukehren.");
                Console.ReadLine();
            }
        }
    }
}
