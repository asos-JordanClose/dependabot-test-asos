using NUnit.Framework;
using FluentAssertions;

namespace Dependabot.UnitTests
{
    [TestFixture]
    public class FakeClassShould
    {
        [TestCase("Depend", "abot")]
        [TestCase("Test", "Case")]
        [TestCase("Hello", "World")]
        [TestCase("", "")]
        public void CombineString(string firstHalf, string secondHalf)
        {
            FakeClass fakeClass = new FakeClass();

            string result = fakeClass.CombineString(firstHalf, secondHalf);

            result.Should().BeEquivalentTo(firstHalf + secondHalf);
        }
    }
}