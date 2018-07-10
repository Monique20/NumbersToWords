using NUnit.Framework;

namespace NumbersToWordsKata.Tests
{
    [TestFixture]
    public class NumbersToWordsConverterTests
    {
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(4, "four")]
        [TestCase(5, "five")]
        [TestCase(6, "six")]
        [TestCase(7, "seven")]
        [TestCase(8, "eight")]
        [TestCase(9, "nine")]
        public void Convert_GivenUnits_ShouldReturnUnitsInWords(int input, string expected)
        {
            //Arrange
            var sut = CreateNumbersToWordsConverter();

            //Act
            var actual = sut.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(10, "ten")]
        [TestCase(20, "twenty")]
        [TestCase(30, "thirty")]
        [TestCase(40, "forty")]
        [TestCase(50, "fifty")]
        [TestCase(60, "sixty")]
        [TestCase(70, "seventy")]
        [TestCase(80, "eighty")]
        [TestCase(90, "ninety")]
        public void Convert_GivenTens_ShouldReturnTensInWords(int input, string expected)
        {
            //Arrange
            var sut = CreateNumbersToWordsConverter();

            //Act
            var actual = sut.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        public void Convert_GivenATeenNumber_ShouldReturnInWords(int input, string expected)
        {
            //Arrange
            var sut = CreateNumbersToWordsConverter();

            //Act
            var actual = sut.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private static NumbersToWordsConverter CreateNumbersToWordsConverter()
        {

            return new NumbersToWordsConverter();
        }

    }
}
