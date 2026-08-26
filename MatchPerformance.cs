public class MatchPerformance
{
    public int MatchID { get; set; }
    public Player Player { get; set; }
    public string Champion { get; set; }
    public int Kills { get; set; }
    public int Deaths { get; set; }
    public int Assists { get; set; }

    public MatchPerformance(
        int matchID,
        Player player,
        string champion,
        int kills,
        int deaths,
        int assists)
    {
        MatchID = matchID;
        Player = player;
        Champion = champion;
        Kills = kills;
        Deaths = deaths;
        Assists = assists;
    }
}