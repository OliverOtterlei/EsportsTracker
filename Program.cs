

Team t1 = new Team("T1");
t1.Players.Add(new Player("Faker", "Mid"));
t1.Players.Add(new Player("Caps", "Mid"));
t1.Players.Add(new Player("ShowMaker", "Mid"));

t1.Players.Add(new Player("Oner", "Jungle"));
t1.Players.Add(new Player("Canyon", "Jungle"));
t1.Players.Add(new Player("Kanavi", "Jungle"));

t1.Players.Add(new Player("Keria", "Support"));
t1.Players.Add(new Player("Mikyx", "Support"));
t1.Players.Add(new Player("Lehends", "Support"));

t1.Players.Add(new Player("Gumayusi", "ADC"));
t1.Players.Add(new Player("Peyz", "ADC"));
t1.Players.Add(new Player("GALA", "ADC"));

t1.Players.Add(new Player("Zeus", "Top"));
t1.Players.Add(new Player("Bin", "Top"));
t1.Players.Add(new Player("Kiin", "Top"));
/*
while (true)
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";
    while (name == "")
    {
        name = Console.ReadLine() ?? "";
    }
    Console.Write("Role: ");
    string role = Console.ReadLine() ?? "";
    while (role == "")
    {
        role = Console.ReadLine() ?? "";
    }
    Player player1 = new Player(name, role);
    t1.Players.Add(player1);

    Console.Write("Add another? (y / n): ");
    string choice = Console.ReadLine() ?? "";
    if (choice == "n")
    {
        break;
    }
}*/

var midPlayers = t1.Players.Where(p => p.Role == "Mid");
Player? faycuh = midPlayers.FirstOrDefault(p => p.Name == "Faker");

var names = t1.Players.Select(p => p.Name);
var sortedPlayers = t1.Players.OrderBy(p => p.Role).ThenBy(p => p.Name);

var isMidThere = t1.Players.Any(p => p.Role == "Mid");

var midLaneCount = t1.Players.Count(p => p.Role == "Mid");

var allHasRole = t1.Players.All(p => p.Role != null);

var groupedPlayers = t1.Players.GroupBy(p => p.Role);

Func<Player, bool> isMid = p => p.Role == "Mid";

Func<Player, bool> isSupp = p => p.Role == "Support";

Func<Player, bool> nameStartsWithK = p => p.Name[0] == 'K';
foreach (Player p in t1.Players)
{
    if (isMid(p))
    {
        Console.WriteLine($"{p.Name} is a {p.Role} player!");
    }
    if (isSupp(p))
    {
        Console.WriteLine($"{p.Name} is a {p.Role} player!");
    }
    if (nameStartsWithK(p))
    {
        Console.WriteLine($"{p.Name} starts with K!");
    }
}


var playersByName = t1.Players.ToDictionary(p => p.Name);
if (playersByName.TryGetValue("Chovy", out Player? player))
{
    Console.WriteLine(player.Role);
}
else
{
    Console.WriteLine("Couldn't retrieve player");
}


/*

foreach (var group in groupedPlayers)
{
    if (group.Key == "Support")
    {
        Console.WriteLine(group.Key);
        foreach (Player player in group)
        {
            Console.WriteLine($"    {player.Name}, {player.Role}");
        }
    }
    
}*/

/*if (faycuh != null)
{
    Console.WriteLine($"Faker: {faycuh.Name}");
}

Console.WriteLine("Players, sorted by role:");
foreach (Player p in sortedPlayers)
{
    Console.WriteLine($"{p.Name}, {p.Role}");
}

if (allHasRole)
{
    Console.WriteLine("No one lacks a role");
}

if (isMidThere)
{
    Console.WriteLine("contains Mid laner");
    Console.WriteLine($"Amount: {midLaneCount}");
}*/


