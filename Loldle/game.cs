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

    public EmojiChamp StartEmoji()
    {
        var program = new Program();

        var emojiCollection = program.JsonEmoji();

        Random rnd = new Random();

        int index = rnd.Next(emojiCollection.emoji.Count);

        var emojiChamp = emojiCollection.emoji.ElementAt(index).Value;

        return emojiChamp;

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

    public (int, EmojiChamp) checkEmojiAnswer(string inputText, EmojiChamp champion)
    {
        Program program = new Program();

        var championNames = program.EmojiChampionNames();

        string input = inputText.ToLower();

        EmojiChamp champio = new EmojiChamp();

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
            var championCollection = program.JsonEmoji();
            var championInput = championCollection.emoji.ElementAt(index).Value;

            return (1, championInput);

        }
    }
    public void game()
    {

    }

}