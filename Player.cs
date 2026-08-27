
public class Player
{
    public string PlayerID { get; set; }
    public string Name { get; set; }
    public Team Team { get; set; }
    public List<MatchPerformance> MatchPerformances { get; set; }
    public Player(string id, string name, Team team)
    {
        PlayerID = id;
        Name = name;
        Team = team;

        MatchPerformances = new List<MatchPerformance>();
    }
}