using ConsoleApp4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.ComponentModel;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        [System.ComponentModel.Category("Addition")]
        public void TestAddingTwoPositiveIntegerNumbers()
        {
            //Arrange
            int a = 5;
            int b = 9;

            //Act
            double result = Program.Add(a, b);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 14);
            

        }

        [Test]
        [System.ComponentModel.Category("Addition")]
        public void TestAddingTwoPositiveFloatingPointNumbers()
        {
            //Arrange
            double a = 5.43;
            double b = 0.33;

            //Act
            double result = Program.Add(a, b);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 5.76);
        }

        [Test]
        [System.ComponentModel.Category("Addition")]
        public void TestAddingTwoNegativeNumbers()
        {
            //Arrange
            double a = -3.431;
            double b = -3.241;

            //Act
            double result = Program.Add(a, b);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, -6.672, 0.00001);
        }

        [Test]
        [System.ComponentModel.Category("Addition")]
        public void TestAddingTwoZeroes()
        {
            double a = 0;
            double b = 0;

            double result = Program.Add(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 0);
        }

        [Test]
        [System.ComponentModel.Category("Addition")]
        public void TestAddingZeroAndNumber()
        {
            double a = 1;
            double b = 0;

            double result = Program.Add(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 1);
        }

        [Test]
        [System.ComponentModel.Category("Addition")]
        public void TestAddingOppositeNumbers()
        {
            double a = -5.34;
            double b = 5.34;

            double result = Program.Add(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 0);
        }

        [Test]
        [System.ComponentModel.Category("Subtraction")]
        public void TestSubtractionFirstBigger()
        {
            double a = 5;
            double b = 3;

            double result = Program.Subtract(a, b);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 2);
        }

        [Test]
        [NUnit.Framework.Category("Subtraction")]
        public void TestSubtractionSecondBigger()
        {
            double a = 3;
            double b = 5;

            double result = Program.Subtract(a, b);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, -2);
        }

        [Test]
        [System.ComponentModel.Category("Subtraction")]
        public void TestSubtractZero()
        {
            double a = 3;
            double b = 0;

            double result = Program.Subtract(a, b);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 3);
        }

        [Test]
        [System.ComponentModel.Category("Subtraction")]
        public void TestSubtractNegativeNumbers()
        {
            double a = -3;
            double b = -5;

            double result = Program.Subtract(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 2);
        }

        [Test]
        [NUnit.Framework.Category("Multiplication")]
        public void TestMultiplicationTwoPositiveNumbers()
        {
            double a = 3;
            double b = 2.5;

            double result = Program.Multiply(a, b);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 7.5);
        }

        [Test]
        [System.ComponentModel.Category("Multiplication")]
        public void TestMultiplicationTwoNegativeNumbers()
        {
            double a = -3;
            double b = -2;
            double result = Program.Multiply(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 6);
        }
        [Test]
        [NUnit.Framework.Category("Multiplication")]
        public void TestMultiplicationTwoDifferentSignedNumbers()
        {
            double a = -3;
            double b = 2;
            double result = Program.Multiply(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, -6);
        }

        [Test]
        [NUnit.Framework.Category("Multiplication")]
        public void TestMultiplicationWithZero()
        {
            double a = 0;
            double b = 3;

            double result = Program.Multiply(a, b);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 0);
        }

        [Test]
        [NUnit.Framework.Category("Division")]
        public void TestDivisionWithTwoNumbers()
        {
            double a = 3;
            double b = 2;

            double result = Program.Division(a, b);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 1.5);
        }

        [Test]
        [NUnit.Framework.Category("Division")]
        public void TestDivisionWithBiggerNumber()
        {
            double a = 3;
            double b = 5;

            double result = Program.Division(a, b);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, 0.6);
        }

        [Test]
        [NUnit.Framework.Category("Division")]
        public void TestDivisionZeroByNumber()
        {
            double a = 0;
            double b = 5;

            double result = Program.Division(a, b);


        }

        [Test]
        [NUnit.Framework.Category("Division")]
        public void TestDivisionByZero()
        {
            double a = 5;
            double b = 0;

            //object value = NUnit.Framework.Assert.ThrowsException<DivideByZeroException>(() => Program.Division(a, b));
        }
    }
}
