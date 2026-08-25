public class Match
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Team Winner { get; set; }
    public List<MatchPerformance> Performances { get; set; }

    public Match(Team team1, Team team2, Team winner)
    {
        Team1 = team1;
        Team2 = team2;
        Winner = winner;
        Performances = new List<MatchPerformance>();
    }
}