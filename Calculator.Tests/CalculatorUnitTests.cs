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

    }
}
