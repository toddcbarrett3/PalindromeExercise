using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("radar", true)]
        [InlineData("racecar", true)]
        [InlineData("hiking", false)]
        [InlineData("fishing", false)]
        public void IsAPalindromeTest(string input, bool expected)
        {
            WordSmith palindrome = new WordSmith();
            
            var actual = palindrome.IsAPalidrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
