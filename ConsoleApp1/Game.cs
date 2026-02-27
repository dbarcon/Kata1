using System.Security.Cryptography;

namespace ConsoleApp1;

public class Game
{
    public int TargetNumber { get; set; }

    public Game(RandomNumberGenerator randomNumberGenerator)
    {
        this.TargetNumber = randomNumberGenerator.Generate();
    }

    public string Guess(int guessedNumber)
    {
        if (guessedNumber > TargetNumber)
        {
            return "Lower";
        }

        if (guessedNumber < TargetNumber)
        {
            return "Higher";
        }

        return "Win";
    }
}

public class RandomNumberGenerator
{
    public int Generate()
    {
        return 5;
    }
}