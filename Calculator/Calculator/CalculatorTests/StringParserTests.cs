using System.Linq;


using Xunit;

using Calculator.Core;

namespace CalculatorTests
{
    public class StringParserTests
    {
        [Theory]
        [InlineData("2+3")]
        public void HandleBrackets_NoBrackets_Success(string userInput)
        {
            var result = StringParser.HandleBrackets(userInput);

            Assert.Single(result);
            Assert.Equal(userInput, result.ElementAt(0));
        }

        [Theory]
        [InlineData("(2+3)")]
        [InlineData("(2+4)")]
        [InlineData("(2+4) * 2")]

        public void HandleBrackets_1SetOfBracketsBrackets_Success(string userInput)
        {

        }

        [Theory]
        [InlineData("((2+3))")]
        public void HandleBrackets_MultipleBracketsUsed_ErrorThrown(string userInput)
        {

        }
    }
}