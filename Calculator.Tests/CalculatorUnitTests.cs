using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Calculator;
using Xunit;

namespace Calculator.Tests
{
    public class Calculator
    {
        public int Calcualte(string input)
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorUnitTests
    {

        [Fact]
        public void SingleNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Calcualte("1");
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void AddTwoNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Calcualte(" 1,2");
            Assert.Equal(3, result);
        }

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
            //Unit Tests for Step 4
            // Arrange
            int expected = 5;
            double[] array = new double[] { 1, 1, 1, 1, 1, 0 };

            // Act
            double actual_result = WordCalc.Sum_MultipleNumbers(array);

            // Assert
            Assert.Equal(expected, actual_result);

        }
        
        [Fact]
        public void Test_SumHandlingDelimiters()
        {
            // Arrange
            int expected = 20;
            
            // Act
            int actual_result = WordCalc.SumHandlingDelimiters("3\n5\n3, 9",0);

            // Assert
            Assert.Equal(expected, actual_result);

        }

        [Fact]
        public void Test_SumHandlingDelimiters_Step6()
        {
            // Arrange
            int expected = 3;

            // Act
            int actual_result = WordCalc.SumHandlingDelimiters("//;\n1;2",0);

            // Assert
            Assert.Equal(expected, actual_result);

        }

        [Fact]
        public void Test_SumHandlingDelimiters_Steps4()
        {
            // Arrange
            int expected = 1051;
            double[] array = new double[]{1, 50, 999, 1, 0};

            // Act
            double actual_result = WordCalc.Sum_MultipleNumbers(array);

            // Assert
            Assert.Equal(expected, actual_result);
        }

        [Fact]
        public void Test_SumHandlingDelimiters_Steps7()
        {
            // Arrange
            int expected = 2050;
            double[] array = new double[] { 1, 50, 999, 1000, 0 };

            // Act
            double actual_result = WordCalc.Sum_MultipleNumbers(array);

            // Assert
            Assert.Equal(expected, actual_result);
        }

        [Fact]
        public void Test_SumHandlingDelimiters_Steps8()
        {
            // Arrange
            int expected = 948;
            double[] array = new double[] { -1, -50, 999 };

            // Act
            double actual_result = WordCalc.Sum_MultipleNumbers(array);

            // Assert
            Assert.Equal(expected, actual_result);
        }
                
    }
}
