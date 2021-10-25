using System;
using Xunit;
using ClassMathFunc;

namespace TestMathFunc
{
    public class UnitTestMathFunc
    {
        [Fact]
        public void TestFactorial()
        {
            // Arrange
            int my_num = 5;
            int expect = 120;

            // Act
            ClassMyMathFunc classMyMath = new ClassMyMathFunc();
            int actual = classMyMath.Factorial(my_num);

            // Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void TestMultiplication()
        {
            // Arrange
            int x = 5, y = 7;
            int expect = 35;

            // Act
            ClassMyMathFunc classMyMath = new ClassMyMathFunc();
            int actual = classMyMath.Multiplication(x, y);

            // Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void TestAddition()
        {
            // Arrange
            int x = 5, y = 7;
            int expect = 12;

            // Act
            ClassMyMathFunc classMyMath = new ClassMyMathFunc();
            int actual = classMyMath.Addition(x, y);

            // Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void TestSubtraction()
        {
            // Arrange
            int x = 5, y = 7;
            int expect = -2;

            // Act
            ClassMyMathFunc classMyMath = new ClassMyMathFunc();
            int actual = classMyMath.Subtraction(x, y);

            // Assert
            Assert.Equal(expect, actual);
        }
    }
}
