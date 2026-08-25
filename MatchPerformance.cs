public class MatchPerformance
{
    public Player Player { set; get; }
    public string Champion { set; get; }
    public int Kills { set; get; }
    public int Deaths { set; get; }
    public int Assists { set; get; }

    public MatchPerformance(Player player, string champ, int kills, int deaths, int assists)
    {
        Player = player;
        Champion = champ;
        Kills = kills;
        Deaths = deaths;
        Assists = assists;
    }
}