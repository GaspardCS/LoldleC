public class Game 
{

    public Champion Start()
    {
        var program = new Program();

        var championCollection = program.Json();

        Random rnd = new Random();

        int index = rnd.Next(championCollection.Champions.Count);

        var champion = championCollection.Champions.ElementAt(index).Value;

        return champion;

    }

    public (int, Champion) checkAnswer(string inputText, Champion champion)
    {
        Program program = new Program();

        var championNames = program.ChampionName();

        string input = inputText.ToLower();

        Champion champio = new Champion();

        int index = Array.IndexOf(championNames, input);
        if (index == -1)
        {
            return (2, champio);
        }
        else if (champion.Name.ToLower() == input)
        {
            return (0, champio);
        }
        else
        {
            var championCollection = program.Json();
            var championInput = championCollection.Champions.ElementAt(index).Value;

            return (1, championInput);

        }
    }
    public void game()
    {

    }

}