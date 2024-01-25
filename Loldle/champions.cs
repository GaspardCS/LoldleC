public class Champion
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Role { get; set; }
    public List<string> Race { get; set; }
    public string Resource { get; set; }
    public List<string> Range { get; set; }
    public List<string> Region { get; set; }
    public string Date { get; set; }
}

public class ChampionCollection
{
    public Dictionary<string, Champion> Champions { get; set; }
}
