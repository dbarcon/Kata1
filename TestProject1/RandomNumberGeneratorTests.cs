using AwesomeAssertions;
using ConsoleApp1;

namespace TestProject1;

public class RandomNumberGeneratorTests
{
    [Test]
    public void RandomNumberGenerator_Generates_Random_Number()
    {
        var randomNumberGenerator = new RandomNumberGenerator(1,1);
        
        var randomNumber = randomNumberGenerator.Generate();
        
        randomNumber.Should().Be(1);
    }
}