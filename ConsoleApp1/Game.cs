using System.Security.Cryptography;

namespace ConsoleApp1;

public class Game
{
    private const int LimitOfAttmepts = 3;
    private int targetNumber;
    private int attempts = 0;

    public Game(RandomNumberGenerator randomNumberGenerator)
    {
        targetNumber = randomNumberGenerator.Generate();
    }

    public GameResult Guess(int guessedNumber)
    {
        attempts++;
        if (attempts == LimitOfAttmepts)
        {
            return GameResult.Loose;
        }
        if (guessedNumber > targetNumber)
        {
            return GameResult.Lower;
        }
        if (guessedNumber < targetNumber)
        {
            return GameResult.Higher;
        }

        return GameResult.Win;
    }
}
public enum GameResult
{
    Win,
    Higher,
    Lower,
    Loose
}


public class RandomNumberGenerator
{
    public int Generate()
    {
        return 5;
    }
}