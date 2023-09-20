using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace Warm_oder_Kalt;

internal class Serialisierung
{
    public static void Speichern()
    {
        try
        {
            string json = JsonConvert.SerializeObject(Spieler.SpielerListe.OrderBy(s => s.Score), Newtonsoft.Json.Formatting.Indented);

            using (StreamWriter sw = new StreamWriter("SpielerListe.json"))
            {
                sw.WriteLine(json);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Die Highscores wurden gespeichert. Drücke ENTER um fortzufahren.");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void Laden()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string json;
            if (File.Exists("SpielerListe.json"))
            {
                using (StreamReader sr = new StreamReader("SpielerListe.json"))
                {
                    json = sr.ReadToEnd();
                }
                Spieler.SpielerListe = JsonConvert.DeserializeObject<List<Spieler>>(json);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Die Highscores wurden geladen. Drücke ENTER um fortzufahren.");
                Console.ReadLine();
            }
            else throw new FileNotFoundException("Highscores File nicht gefunden.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void Ausgabe()
    {
        Console.Clear();
        foreach (var highscore in Spieler.SpielerListe.OrderBy(s => s.Score))
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n\nName: {highscore.Name}\t\tScore(Versuchen): {highscore.Score}");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\nDrücke ENTER um fortzufahren.");
        Console.ReadLine();
    }
}


