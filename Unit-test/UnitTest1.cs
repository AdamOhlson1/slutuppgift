using Xunit;
using Unittest;

namespace Unittest
{
    public class morseCode
    {
        [Fact]
        public void MordeCodeTest_returnTrue()
        {
            // Arrange
            var text = "HELLO";
            var expectedMorseCode = ".... . .-.. .-.. ---";

            // Act
            var actualMorseCode = ProgramTester.KrypteraMorse(text);

            // Assert
            Assert.Equal(expectedMorseCode, actualMorseCode);
        }

        [Fact]
        public void MordeCodeTest_returnFalse()
        {
            // Arrange
            var text = "HELLO";
            var expectedMorseCode = ".... . .-.. .-.. .-";

            // Act
            var actualMorseCode = ProgramTester.KrypteraMorse(text);

            // Assert
            Assert.NotEqual(expectedMorseCode, actualMorseCode);
        }
    }
}
