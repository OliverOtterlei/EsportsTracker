
public class Player
{
    public string Name { get; set; }
    public string Role { get; set; }
    public Team Team { get; set; }
    public Player(string name, string role, Team team)
    {
        Name = name;
        Role = role;
        Team = team;
    }
}