using Xunit;

using Calculator.Core;

namespace CalculatorTests
{
    public class StringParserTests
    {
        [Theory]
        [InlineData("3", 3)]
        public void HandleBrackets_NoBrackets_Success(string userInput, long expected)
        {
            var result = StringParser.ParseNumber(userInput);

            Assert.Equal(expected, result);
        }
    }
}