
public class Team
{
    public string Name { get; set; }
    public List<Player> Players;

    public Team(string name)
    {
        Name = name;
        
        Players = new List<Player>();
    }
}