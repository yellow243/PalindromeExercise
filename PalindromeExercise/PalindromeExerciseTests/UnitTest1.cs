using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1 
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello",false)]
        [InlineData("nun",true)]
        [InlineData("kayak", true)]
        [InlineData("ach", false)]
        [InlineData("rotator", true)]
        public void MyTest(string word, bool expected)
        {
            var tester = new WordSmith();

            bool actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
