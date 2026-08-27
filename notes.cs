/*
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Net.Mail;

Team t1 = new Team("T1");
Team genG = new Team("Gen.G");
t1.Players.Add(new Player("Faker", "Mid", t1));
t1.Players.Add(new Player("Oner", "Jungle", t1));
t1.Players.Add(new Player("Keria", "Support", t1));
t1.Players.Add(new Player("Gumayusi", "ADC", t1));
t1.Players.Add(new Player("Peyz", "ADC", t1));
t1.Players.Add(new Player("Zeus", "Top", t1));

genG.Players.Add(new Player("Chovy", "Mid", genG));
genG.Players.Add(new Player("Canyon", "Jungle", genG));
genG.Players.Add(new Player("Ruler", "ADC", genG));
genG.Players.Add(new Player("Kiin", "Top", genG));
genG.Players.Add(new Player("Duro", "Support", genG));

List<Team> teams = new List<Team>
{
    t1,
    genG
};

var allPlayers = teams.SelectMany(t => t.Players);
/*
foreach (Player p in allPlayers)
{
    Console.WriteLine($"{p.Name}");
}*/

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
/*
var midPlayers = t1.Players.Where(p => p.Role == "Mid");
Player? faycuh = midPlayers.FirstOrDefault(p => p.Name == "Faker");

var names = t1.Players.Select(p => p.Name);
var sortedPlayers = t1.Players.OrderBy(p => p.Role).ThenBy(p => p.Name);

var isMidThere = t1.Players.Any(p => p.Role == "Mid");

var midLaneCount = t1.Players.Count(p => p.Role == "Mid");

var allHasRole = t1.Players.All(p => p.Role != null);

var groupedPlayers = t1.Players.GroupBy(p => p.Role);
var t1PlayersByName = t1.Players.ToDictionary(p => p.Name);
var genGPlayersByName = genG.Players.ToDictionary(p => p.Name);

Func<Player, bool> isMid = p => p.Role == "Mid";

Func<Player, bool> isSupp = p => p.Role == "Support";

Func<Player, bool> nameStartsWithK = p => p.Name[0] == 'K';

Func<Player, bool> isSuppOrMid = p => p.Role == "Support" || p.Role == "Mid";
Func<Player, bool> isMidAndStartsWithF = p => p.Role == "Mid" && p.Name[0] == 'F';
Func<Player, string> getName = p => p.Name;
Func<Player, string> getRole = p => p.Role;
Func<MatchPerformance, int> getkills = p => p.Kills;

//PrintMatching(t1.Players, isSuppOrMid, getName, getRole);
List<MatchPerformance> performances = new List<MatchPerformance>();

/*
if (playersByName.TryGetValue("Faker", out Player? faker))
{
    match1.Performances.Add(
        new MatchPerformance(faker, "Ahri", 8, 2, 6)
    );
}

if (playersByName.TryGetValue("Zeus", out Player? zeus))
{
    match1.Performances.Add(
        new MatchPerformance(zeus, "Gnar", 4, 5, 7)
    );
}

if (playersByName.TryGetValue("Keria", out Player? keria))
{
    match1.Performances.Add(
        new MatchPerformance(keria, "Rakan", 1, 3, 15)
    );
}

if (playersByName.TryGetValue("Gumayusi", out Player? guma))
{
    match1.Performances.Add(
        new MatchPerformance(guma, "Jinx", 10, 1, 5)
    );
}

if (playersByName.TryGetValue("Oner", out Player? oner))
{
    match1.Performances.Add(
        new MatchPerformance(oner, "Vi", 4, 3, 11)
    );
}

int totalKills = performances.Sum(getkills);
double avgKills = performances.Average(getkills);
int leastKills = performances.Min(getkills);
var topKills = performances.OrderByDescending(getkills).Take(3);
*/
/*foreach (MatchPerformance p in topKills)
{
    Console.WriteLine(p.Kills);
}*/

/*
void PrintMatching<T>(List<T> list, Func<T, bool> requirement1, Func<T, string> getName, Func<T, string> getRole)
{
    foreach (T p in list)
    {
        if (requirement1(p))
        {
            string name = getName(p);
            string role = getRole(p);
            Console.WriteLine($"{name} is a {role} player");
        }
    }
}*/

/*
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
*/



//PrintMatchingPlayers(t1.Players, isMid, isSupp);




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
/*
List<Match> matches = new List<Match>();

Match match1 = new Match(1, t1, genG, t1);
Match match2 = new Match(2, t1, genG, genG);

matches.Add(match1);
matches.Add(match2);

if (t1PlayersByName.TryGetValue("Faker", out Player? faker))
{
    match1.Performances.Add(
        new MatchPerformance(1, faker, "Ahri", 8, 2, 6)
    );
}

if (t1PlayersByName.TryGetValue("Zeus", out Player? zeus))
{
    match1.Performances.Add(
        new MatchPerformance(1, zeus, "Gnar", 4, 5, 7)
    );
}

if (t1PlayersByName.TryGetValue("Keria", out Player? keria))
{
    match1.Performances.Add(
        new MatchPerformance(1, keria, "Rakan", 1, 3, 15)
    );
}

if (t1PlayersByName.TryGetValue("Gumayusi", out Player? guma))
{
    match1.Performances.Add(
        new MatchPerformance(1, guma, "Jinx", 10, 1, 5)
    );
}

if (t1PlayersByName.TryGetValue("Oner", out Player? oner))
{
    match1.Performances.Add(
        new MatchPerformance(1, oner, "Vi", 4, 3, 11)
    );
}

if (genGPlayersByName.TryGetValue("Kiin", out Player? kiin))
{
    match1.Performances.Add(
        new MatchPerformance(1, kiin, "Renekton", 1, 7, 5)
    );
}

if (genGPlayersByName.TryGetValue("Canyon", out Player? canyon))
{
    match1.Performances.Add(
        new MatchPerformance(1, canyon, "Sejuani", 3, 6, 8)
    );
}

if (genGPlayersByName.TryGetValue("Chovy", out Player? chovy))
{
    match1.Performances.Add(
        new MatchPerformance(1, chovy, "Azir", 5, 4, 5)
    );
}

if (genGPlayersByName.TryGetValue("Ruler", out Player? ruler))
{
    match1.Performances.Add(
        new MatchPerformance(1, ruler, "Kai'Sa", 4, 4, 4)
    );
}

if (genGPlayersByName.TryGetValue("Duro", out Player? duro))
{
    match1.Performances.Add(
        new MatchPerformance(1, duro, "Nautilus", 1, 6, 10)
    );
}


if (t1PlayersByName.TryGetValue("Faker", out Player? faker2))
{
    match2.Performances.Add(
        new MatchPerformance(2, faker2, "Orianna", 3, 4, 5)
    );
}

if (t1PlayersByName.TryGetValue("Oner", out Player? oner2))
{
    match2.Performances.Add(
        new MatchPerformance(2, oner2, "Xin Zhao", 2, 5, 6)
    );
}

if (t1PlayersByName.TryGetValue("Keria", out Player? keria2))
{
    match2.Performances.Add(
        new MatchPerformance(2, keria2, "Bard", 0, 3, 9)
    );
}

if (t1PlayersByName.TryGetValue("Gumayusi", out Player? guma2))
{
    match2.Performances.Add(
        new MatchPerformance(2, guma2, "Ezreal", 5, 3, 4)
    );
}

if (t1PlayersByName.TryGetValue("Zeus", out Player? zeus2))
{
    match2.Performances.Add(
        new MatchPerformance(2, zeus2, "Jayce", 2, 3, 3)
    );
}

if (genGPlayersByName.TryGetValue("Chovy", out Player? chovy2))
{
    match2.Performances.Add(
        new MatchPerformance(2, chovy2, "Sylas", 6, 2, 7)
    );
}

if (genGPlayersByName.TryGetValue("Canyon", out Player? canyon2))
{
    match2.Performances.Add(
        new MatchPerformance(2, canyon2, "Wukong", 3, 3, 10)
    );
}

if (genGPlayersByName.TryGetValue("Duro", out Player? duro2))
{
    match2.Performances.Add(
        new MatchPerformance(2, duro2, "Rell", 1, 2, 13)
    );
}

if (genGPlayersByName.TryGetValue("Ruler", out Player? ruler2))
{
    match2.Performances.Add(
        new MatchPerformance(2, ruler2, "Aphelios", 6, 2, 6)
    );
}

if (genGPlayersByName.TryGetValue("Kiin", out Player? kiin2))
{
    match2.Performances.Add(
        new MatchPerformance(2, kiin2, "K'Sante", 2, 3, 8)
    );
}


foreach (Match match in matches)
{
    Console.WriteLine($"{match.Team1.Name} vs {match.Team2.Name}");
    Console.WriteLine($"Winner: {match.Winner.Name}");

    foreach (MatchPerformance performance in match.Performances)
    {
        Console.WriteLine(
            $"{performance.Player.Name} - {performance.Champion} - {performance.Kills}/{performance.Deaths}/{performance.Assists}"
        );
    }
}

var t1WinCounter = matches.Count(m => m.Winner == t1);

Console.WriteLine($"T1 wins: {t1WinCounter}");


List<string> lines = new List<string>();

lines.Add("MatchID,Player,Champion,Kills,Deaths,Assists");

foreach (Match match in matches)
{
    foreach (MatchPerformance matchPerformance in match.Performances)
    {
        string line =
            $"{match.ID},{matchPerformance.Player.Name},{matchPerformance.Champion},{matchPerformance.Kills},{matchPerformance.Deaths},{matchPerformance.Assists}";

        lines.Add(line);
    }
}

File.WriteAllLines("performances.csv", lines);


string[] pLines = File.ReadAllLines("performances.csv");

List<string[]> splitLines = new List<string[]>();

foreach (string line in pLines)
{
    string[] parts = line.Split(',');

    splitLines.Add(parts);
}


foreach (string[] line in splitLines)
{
    foreach (string part in line)
    {
        Console.Write($"{part} ");
    }

    Console.WriteLine();
}


Match testMatch1 = new Match(1, t1, genG, t1);
Match testMatch2 = new Match(2, t1, genG, genG);

List<Match> testMatches = new List<Match>();
testMatches.Add(testMatch1);
testMatches.Add(testMatch2);

foreach (string[] line in splitLines.Skip(1))
{
    string champ = line[2];
    int.TryParse(line[0], out int id);
    int.TryParse(line[3], out int kills);
    int.TryParse(line[4], out int deaths);
    int.TryParse(line[5], out int assists);

    string name = line[1];

    if (t1PlayersByName.TryGetValue(name, out Player? t1Player))
    {
        foreach (Match match in testMatches)
        {
            if (id == match.ID)
            {
                MatchPerformance mp =
                    new MatchPerformance(id, t1Player, champ, kills, deaths, assists);

                match.Performances.Add(mp);    
            }
            
        }
    }
    else if (genGPlayersByName.TryGetValue(name, out Player? genGPlayer))
    {
        foreach (Match match in testMatches)
        {
            if (id == match.ID)
            {
                MatchPerformance mp =
                    new MatchPerformance(id, genGPlayer, champ, kills, deaths, assists);

                match.Performances.Add(mp);    
            }
            
        }
    }
    else
    {
        return;
    }
}


foreach (Match match in testMatches)
{
    foreach (MatchPerformance mp in match.Performances)
    {
        Console.WriteLine(
            $"TEST    ID{mp.MatchID} -- {mp.Player.Name} - {mp.Champion} - {mp.Kills}/{mp.Deaths}/{mp.Assists}"
        );
    }
}



var allPerformances = testMatches.SelectMany(t => t.Performances);

var fakerPerformances = allPerformances.Where(t => t.Player == faker);

var zeusPerformances = allPerformances.Where(t => t.Player == zeus);

var keriaPerformances = allPerformances.Where(t => t.Player == keria);

var gumaPerformances = allPerformances.Where(t => t.Player == guma);

var onerPerformances = allPerformances.Where(t => t.Player == oner);


var kiinPerformances = allPerformances.Where(t => t.Player == kiin);

var canyonPerformances = allPerformances.Where(t => t.Player == canyon);

var chovyPerformances = allPerformances.Where(t => t.Player == chovy);

var rulerPerformances = allPerformances.Where(t => t.Player == ruler);

var duroPerformances = allPerformances.Where(t => t.Player == duro);


int fakerKills = fakerPerformances.Sum(p => p.Kills);


var allGroupedPerformances = allPerformances.GroupBy(p => p.Player);

foreach (var group in allGroupedPerformances)
{
    Player player = group.Key;

    int totalKills = group.Sum(p => p.Kills);
    int totalDeaths = group.Sum(p => p.Deaths);
    int totalAssists = group.Sum(p => p.Assists);
    double totalKDA = (double)(totalKills + totalAssists) / totalDeaths;
    

    Console.WriteLine($"Player: {player.Name}, KDA: {totalKills}/{totalDeaths}/{totalAssists}, summed KDA: {totalKDA:F2}");
}

var playerStats = allGroupedPerformances.Select(group =>
{
    int totalKills = group.Sum(p => p.Kills);
    int totalDeaths = group.Sum(p => p.Deaths);
    int totalAssists = group.Sum(p => p.Assists);
    double totalKDA = (double)(totalKills + totalAssists) / totalDeaths;

    return new
    {
        Player = group.Key,
        KDA = totalKDA
    };
});

var kdaLeaderboard = playerStats.OrderByDescending(p => p.KDA);

int placement = 1;

foreach (var p in kdaLeaderboard)
{
    Console.WriteLine($"{placement}.    {p.Player.Name}    KDA: {p.KDA:F2}");
    placement++;
}


var fakerGroupByChamps = fakerPerformances.GroupBy(p => p.Champion);

foreach (var group in fakerGroupByChamps)
{
    string champ = group.Key;
    Console.WriteLine($"{champ}: {group.Count()}");
}

var fakerMostPlayedChamps = fakerGroupByChamps.OrderByDescending(p => p.Count());

var fakerMostPlayedChamp = fakerMostPlayedChamps.FirstOrDefault();

if (fakerMostPlayedChamp != null)
{
    Console.WriteLine($"Fakers most player champ: {fakerMostPlayedChamp.Key} ({fakerMostPlayedChamp.Count()})");
}


var allGroupedByChamp = allGroupedPerformances.Select (group => new
{
    Player = group.Key,
    ChampionGroups = group.GroupBy(g => g.Champion)
});

foreach (var player in allGroupedByChamp)
{
    var mostPlayedGeneral = player.ChampionGroups.OrderByDescending(g => g.Count());
    var mostPlayedChamp = mostPlayedGeneral.FirstOrDefault();
    if (mostPlayedChamp != null)
    {
        Console.WriteLine($"{player.Player.Name}, {mostPlayedChamp.Key}, {mostPlayedChamp.Count()}");
    }
}

foreach (var mp in allPerformances)
{
    foreach (Match match in testMatches)
    {
        if (match.ID == mp.MatchID)
        {
            if (mp.Player.Team == match.Winner)
            {
                Console.WriteLine($"{mp.Player.Name} won");
            }
            else
            {
                Console.WriteLine($"{mp.Player.Name} lost");
            }
        }
    }
}

var t1WonGames = testMatches.Where(g => g.Winner == t1);
var t1LostGames = testMatches.Where(g => (g.Team1 == t1 || g.Team2 == t1) && g.Winner != t1);

var testMatchesByID = testMatches.ToDictionary(m => m.ID);

foreach (var group in allGroupedPerformances)
{
    int wins = 0;
    int games = group.Count();

    foreach (MatchPerformance mp in group)
    {
        if (testMatchesByID[mp.MatchID].Winner == mp.Player.Team)
        {
            wins++;
        }
    }
    double winRate = (double)wins / games * 100;

    Console.WriteLine($"{group.Key.Name} had won {wins} games with a win rate of {winRate:F2}%");

}


*/