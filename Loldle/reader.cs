using Newtonsoft.Json;

public class Reader
{
    public ChampionCollection Json()
    {
        string filePath = "../../../info.json";
        string json = System.IO.File.ReadAllText(filePath);
        ChampionCollection championCollection = JsonConvert.DeserializeObject<ChampionCollection>(json);
        return championCollection;
    }

    public Reader()
    {

    }
}