public class Champion
{

    public string RegionSTR => Region.GetNameElements();
    public string RoleSTR => Role.GetNameElements();
    public string RaceSTR => Race.GetNameElements();
    public string RangeSTR => Range.GetNameElements();


    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Role { get; set; }
    public List<string> Race { get; set; }
    public string Resource { get; set; }
    public List<string> Range { get; set; }
    public List<string> Region { get; set; }
    public string Date { get; set; }
    public string icon { get; set; }
}

public class ChampionCollection
{
    public Dictionary<string, Champion> Champions { get; set; }
}

public class EmojiChamp
{
    public string Name { get; set; }
    public string Emojis { get; set; }
}

public class EmojiChampCollection
{
    public Dictionary<string, EmojiChamp> emoji { get; set; }
}


public static class ClassExtend
{
    public static string GetNameElements(this List<string> list)
    {
        string fullstring = "";
        foreach (var item in list)
        {
            fullstring += item + "\n";
        }
        return fullstring;
    }
}