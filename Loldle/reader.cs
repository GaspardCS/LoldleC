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

    public Program()
    {

    }
}