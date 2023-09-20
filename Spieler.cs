using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_oder_Kalt;

internal class Spieler
{
    public Spieler(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public string Name { get; set; }
    public int Score { get; set; }
    public static List<Spieler> SpielerListe { get; set; } = new List<Spieler>();
}
