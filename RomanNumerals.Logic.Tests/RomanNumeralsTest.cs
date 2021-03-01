using Xunit;

namespace RomanNumerals.Logic.Tests
{
    public class RomanNumeralsTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void ToRoman_SingleNumeralResult_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }

        [Theory]
        
        [InlineData(2, "II")]
        [InlineData(20, "XX")]
        [InlineData(200, "CC")]
        [InlineData(2000, "MM")]

        [InlineData(3, "III")]
        [InlineData(30, "XXX")]
        [InlineData(300, "CCC")]
        [InlineData(3000, "MMM")]

        [InlineData(4000, "MMMM")]

        [InlineData(6, "VI")]
        [InlineData(1666, "MDCLXVI")]
        public void ToRoman_SimpleMultipleNumeralsResult_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }

        [Theory]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        public void ToRoman_NextMinusPreviousResult_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }

        [Theory]
        [InlineData(1999, "MCMXCIX")]
        [InlineData(1444, "MCDXLIV")]
        public void ToRoman_ComplicatedStuff_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        public void FromRoman_SingleNumeralInput_MatchesExpectation(string input, int expected)
        {
            Assert.Equal(expected, RomanNumerals.FromRoman(input));
        }

        [Theory]
        [InlineData("II", 2)]
        [InlineData("XX", 20)]
        [InlineData("CC", 200)]
        [InlineData("MM", 2000)]

        [InlineData("III", 3)]
        [InlineData("XXX", 30)]
        [InlineData("CCC", 300)]
        [InlineData("MMM", 3000)]

        [InlineData("MMMM", 4000)]

        [InlineData("VI", 6)]
        [InlineData("MDCLXVI", 1666)]
        public void FromRoman_SimpleMultipleNumeralsInput_MatchesExpectation(string input, int expected)
        {
            Assert.Equal(expected, RomanNumerals.FromRoman(input));
        }

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        public void FromRoman_NextMinusPreviousInput_MatchesExpectation(string input, int expected)
        {
            Assert.Equal(expected, RomanNumerals.FromRoman(input));
        }

        [Theory]
        [InlineData("MCMXCIX", 1999)]
        [InlineData("MCDXLIV", 1444)]
        public void FromRoman_ComplicatedStuff_MatchesExpectation(string input, int expected)
        {
            Assert.Equal(expected, RomanNumerals.FromRoman(input));
        }
    }
}