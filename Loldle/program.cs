using Newtonsoft.Json;

public class Program
{
    public ChampionCollection Json()
    {
        string filePath = "../../../info.json";
        string json = System.IO.File.ReadAllText(filePath);
        ChampionCollection championCollection = JsonConvert.DeserializeObject<ChampionCollection>(json);
        return championCollection;
    }
    
    public EmojiChampCollection JsonEmoji()
    {
        string filePath = "../../../emoji.json";
        string json = System.IO.File.ReadAllText(filePath);
        EmojiChampCollection emojiCollection = JsonConvert.DeserializeObject<EmojiChampCollection>(json);
        return emojiCollection;
    }

    public string[] ChampionName()
    {
        var championCollection = Json();
        string[] championNames = new string[championCollection.Champions.Count];
        int i = 0;
        foreach (var champion in championCollection.Champions)
        {
            championNames[i] = champion.Value.Name.ToLower();
            i++;
        }

        return championNames;
    }

    public string[] EmojiChampionNames()
    {
        var championCollection = JsonEmoji();
        string[] championNames = new string[championCollection.emoji.Count];
        int i = 0;
        foreach (var champion in championCollection.emoji)
        {
            championNames[i] = champion.Value.Name.ToLower();
            i++;
        }

        return championNames;
    }

    public Program()
    {

    }
}