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

    public string Guess(int guessedNumber)
    {
        attempts++;
        if (attempts == LimitOfAttmepts)
        {
            return "You lost";
        }
        if (guessedNumber > targetNumber)
        {
            return "Lower";
        }

        if (guessedNumber < targetNumber)
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