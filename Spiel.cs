using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_oder_Kalt;

internal class Spiel
{
    public static void Play()
    {
        Random random = new Random();
        int zufaelligeZahl = random.Next(0, 101);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nBitte gib einen Namen ein.");
        Spieler spieler = new Spieler("", 0);
        spieler.Name = Console.ReadLine();
        Console.Clear();

        int zahl = WertErmitteln();

        int zahl2;
        int zaehler = 1;

        if (zahl == zufaelligeZahl)
        {
            Console.Clear();
            Console.WriteLine("\r\n  _                        _                        \r\n (_|   |                  (_|   |   |_/ o           \r\n   |   |   __               |   |   |        _  _   \r\n   |   |  /  \\_ |   |       |   |   |   |   / |/ |  \r\n    \\_/|/ \\__/   \\_/|_/      \\_/ \\_/    |_/   |  |_/\r\n      /|                                            \r\n      \\|                                            \r\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{zahl} ist richtig!\nHerzlichen Glückwunsch, {spieler.Name}! Du hast gewonnen!\nDu hast es mit nur 1 Versuche geschafft.\n\nThat's an unbeatable Highscore right there!");
            Console.WriteLine("Bitte drücke Enter, um fortzufahren.");
            Console.ReadLine();
            spieler.Score = 1;
            Spieler.SpielerListe.Add(spieler);
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Leider nicht ganz richtig. Versuche es bitte nochmal.");
            zahl2 = WertErmitteln();
            zaehler++;

            bool gewonnen = false;
            do
            {
                int differenzZahl = Math.Abs(zahl - zufaelligeZahl);
                int differenzZahl2 = Math.Abs(zahl2 - zufaelligeZahl);
                if (zahl2 == zufaelligeZahl)
                {
                    Console.Clear();
                    Console.WriteLine("\r\n  _                        _                        \r\n (_|   |                  (_|   |   |_/ o           \r\n   |   |   __               |   |   |        _  _   \r\n   |   |  /  \\_ |   |       |   |   |   |   / |/ |  \r\n    \\_/|/ \\__/   \\_/|_/      \\_/ \\_/    |_/   |  |_/\r\n      /|                                            \r\n      \\|                                            \r\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{zahl2} ist richtig!\nHerzlichen Glückwunsch, {spieler.Name}! Du hast gewonnen!\nDu hast es mit {zaehler} Versuchen geschafft.\n\n");
                    Console.WriteLine("Bitte drücke Enter, um fortzufahren.");
                    Console.ReadLine();
                    spieler.Score = zaehler;
                    Spieler.SpielerListe.Add(spieler);
                    gewonnen = true;
                }
                else if (differenzZahl2 < differenzZahl)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("WÄRMER! Komm, du schaffst das!");
                    zahl = zahl2;
                    zahl2 = WertErmitteln();
                    zaehler++;
                }
                else if (differenzZahl2 > differenzZahl)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("KÄLTER! Was machst du?!");
                    zahl = zahl2;
                    zahl2 = WertErmitteln();
                    zaehler++;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("Kein echter Unterschied.");
                    zahl = zahl2;
                    zahl2 = WertErmitteln();
                    zaehler++;
                }
            } while (gewonnen == false);
        }

    }

    public static int WertErmitteln()
    {
        bool check;
        bool repeat;
        int nummer;
        do
        {
            repeat = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Bitte gib eine Zahl zwischen 0 und 100 ein.");
                check = int.TryParse(Console.ReadLine(), out nummer);
            } while (check == false);
            if (nummer < 0 || nummer > 100)
            {
                Console.Clear();
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Falsche Zahleneingabe.\n");
            }
        } while (repeat);

        return nummer;
    }
}
