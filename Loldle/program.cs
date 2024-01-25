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

    public Program()
    {

    }
}