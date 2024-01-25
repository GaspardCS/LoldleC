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

    public bool checkAnswer(string inputText, Champion champion)
    {
        if (inputText == champion.Name)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void game()
    {

    }

}