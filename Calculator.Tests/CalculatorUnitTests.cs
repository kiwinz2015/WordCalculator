using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Calculator;
using Xunit;

namespace Calculator.Tests
{

    public class CalculatorUnitTests
    {
        [Fact]
        public void Add_TwoNumbers()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual_result = WordCalc.SimpleSum(2, 3);

            // Assert
            Assert.Equal(expected, actual_result);

        }

        [Fact]
        public void Return_MyNumber()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual_result = WordCalc.ReturnMyNumber(5);

            // Assert
            Assert.Equal(expected, actual_result);

        }

        
        [Fact]
        public void Test_myWordLength()
        {
            // Arrange
            int expected = 3;

            // Act
            int actual_result = WordCalc.myWordLength("BBQ");

            // Assert
            Assert.Equal(expected, actual_result);

        }
        
        [Fact]
        public void Test_MultipleSum()
        {
            // Arrange
            int expected = 5;
            double[] array = new double[] { 1, 1, 1, 1, 1, 0 };

            // Act
            double actual_result = WordCalc.Sum_MultipleNumbers(array);

            // Assert
            Assert.Equal(expected, actual_result);

        }

    }
}
