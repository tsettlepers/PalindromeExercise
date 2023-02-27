using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("abCcba",true)]
        [InlineData("Bob",true)]
        [InlineData("aa",true)]
        [InlineData("a",true)]
        [InlineData("ab",false)]
        [InlineData("abc",false)]
        [InlineData("abcdefcba",false)]
        [InlineData("",false)]
        [InlineData(null,false)]

        public void Test1(string trialWord, bool presumed)
        {
            var ws = new WordSmith();
            bool actual = ws.IsAPalindrome(trialWord);
            Assert.Equal(presumed, actual);
        }
    }
}
