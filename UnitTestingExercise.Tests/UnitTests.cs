using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 4, 5, 11)]
        [InlineData(3, 4, 5, 12)]
        [InlineData(2, 0, 5, 7)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();
            var actual = calculator.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,8)]//Add test data <-------
        [InlineData(0, -2, 2)]
        [InlineData(0, 2, -2)]
        [InlineData(0, 0, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator chal= new Calculator();
            //Act
            var actual = chal.Subtract(minuend, subtrhend);

          

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,2,2)]//Add test data <-------
        [InlineData(0, 2, 0)]
        [InlineData(1, 0, 0)]
       
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator test = new Calculator();

            //Act
            var actual = test.Multiply(num1, num2);
           

            //Assert
Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,0,0)]//Add test data <-------
        [InlineData(2, 1,2)]
        [InlineData(0, 2,0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
         
            //Assert

        }

    }
}
