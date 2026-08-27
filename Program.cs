

List<MatchPerformance> performances = new List<MatchPerformance>();
List<Player> players = new List<Player>();
List<Team> teams = new List<Team>();
Team tempTeam = new Team("Temporary place filler");
Player tempPlayer = new Player("", "Temporary place filler", tempTeam);


foreach (string line in File.ReadLines("2026_LoL_esports_match_data_from_OraclesElixir.csv"))
{
    string[] parts = line.Split(',');

    if (parts[13] == "")
    {
        continue;
    }

    Team team = tempTeam;
    Player player = tempPlayer;

    foreach (Team t in teams)
    {
        if (t.Name == parts[15])
        {
            team = t;
            break;
        }
    }

    if (team == tempTeam)
    {
        team = new Team(parts[15]);
        teams.Add(team);
    }

    foreach (Player p in players)
    {
        if (p.PlayerID == parts[14])
        {
            player = p;
            break;
        }
    }

    if (player == tempPlayer)
    {
        player = new Player(parts[14], parts[13], team);
        players.Add(player);
        team.Players.Add(player);
    }

    string id = parts[0];
    string league = parts[3];
    string date = parts[7];
    string game = parts[8];
    string champion = parts[18];
    int.TryParse(parts[31], out int kills);
    int.TryParse(parts[32], out int deaths);
    int.TryParse(parts[33], out int assists);
    bool result;
    if (parts[30] == "1")
    {
        result = true;
    }
    else
    {
        result = false;
    }


    /*if (league == "MSI" && date.StartsWith("2026-07-12"))
    {
        Console.WriteLine($"In game {game} {team} {player} picked {champion} and had a scoreline of {kills}/{deaths}/{assists}. The game ended in a {result} for {team} and {player}");
    }*/
    MatchPerformance mp = new MatchPerformance(id, player, champion, kills, deaths, assists, result);
    performances.Add(mp);
    player.MatchPerformances.Add(mp);
}

Console.WriteLine($"Teams: {teams.Count()}");
Console.WriteLine($"Players: {players.Count()}");
Console.WriteLine($"Performances: {performances.Count()}");

foreach (Player player in players)
{
    if (player.Name == "Faker")
    {
        int totalMatches = 0;
        int totalWins = 0;
        int totalKills = 0;
        int totalDeaths = 0;
        int totalAssists = 0;
        foreach (MatchPerformance mp in player.MatchPerformances)
        {
            totalMatches++;
            totalKills += mp.Kills;
            totalDeaths += mp.Deaths;
            totalAssists += mp.Assists;
            string result;
            if (mp.Result)
            {
                result = "Win";
                totalWins++;
            }
            else
            {
                result = "loss";
            }
            Console.WriteLine($"Player: {player.Name}   Champ: {mp.Champion}    KDA: {mp.Kills}/{mp.Deaths}/{mp.Assists}    Result: {result}");
        }
        Console.WriteLine($"Player: {player.Name}, Total games: {totalMatches}, Total wins: {totalWins}, Total KDA: {totalKills}/{totalDeaths}/{totalAssists}");
    }
}