using AwesomeAssertions;
using NUnit.Framework;
using ConsoleApp1;
using NSubstitute;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private Class1 class1;
        private Class1 class2;

        [SetUp]
        public void Setup()
        {
            class1 = new Class1();
            class2 = Substitute.For<Class1>();
        }

        [Test]
        public void Test1()
        {
            class1.Method1();
            var result = class1.Method1();
            result.Should().Be(0);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void Test2(int value)
        {
            class1.Method1();
            var result = class1.Method1();
            result.Should().Be(value);
        }

        [Test]
        public void Test3()
        {
            class2.Method2(Arg.Any<int>()).Returns(0);
            var result = class2.Method2(1);
            result.Should().Be(0);
        }
    }
}