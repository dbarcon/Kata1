using System.Security.Cryptography;

namespace ConsoleApp1;

public class Game
{
    public int TargetNumber { get; set; }

    public Game()
    {
        this.TargetNumber = 5;
    }

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
        return "Win";
    }
}

public class RandomNumberGenerator
{
    public int Generate()
    {
        throw new NotImplementedException();
    }
}