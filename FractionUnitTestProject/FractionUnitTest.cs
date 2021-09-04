using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FractionUnitTestProject
{
    [TestClass]
    public class FractionUnitTest
    {
        //For practicality just 2 testing methods
        [TestMethod]
        public void TestMethodFractions()
        {
            FractionConsoleApp.Fraction testFraction = new FractionConsoleApp.Fraction();
            
            #region Test Set #1 Basic Fraction 
            testFraction = new FractionConsoleApp.Fraction(1, 2);
            Assert.AreEqual(testFraction.ToString(), "1/2");

            testFraction = new FractionConsoleApp.Fraction(2, 5);
            Assert.AreEqual(testFraction.ToString(), "2/5");

            testFraction = new FractionConsoleApp.Fraction(3, 8);
            Assert.AreEqual(testFraction.ToString(), "3/8");

            testFraction = new FractionConsoleApp.Fraction(15, 40);
            Assert.AreEqual(testFraction.ToString(), "3/8");
            #endregion

            #region Test Set #2 Reduce Fraction 
            //as fraction will convert all the time to "wholeNumber" lets give it a try
            testFraction = new FractionConsoleApp.Fraction(24, 3);
            Assert.AreEqual(testFraction.ToString(), "8");

            testFraction = new FractionConsoleApp.Fraction(25, 10);
            Assert.AreEqual(testFraction.ToString(), "5/2");

            testFraction = new FractionConsoleApp.Fraction(185, 20);
            Assert.AreEqual(testFraction.ToString(), "37/4");

            //as fraction will convert all the time to "wholeNumber" lets give it a try
            testFraction = new FractionConsoleApp.Fraction(33,24);
            Assert.AreEqual(testFraction.ToString(), "11/8");
            #endregion
        }

        //Test using my Fraction Assert and Fraction Exception (when Zero in Denominator)
        [TestMethod()]
        public void ExceptionTestZero()
        {
            MyFractionTestAssert.Throws<FractionConsoleApp.FractionException>(() => new FractionConsoleApp.Fraction(0,0));
        }

        //Test using my Fraction Assert and Fraction Exception (when null in Constructor)
        [TestMethod()]
        public void ExceptionTestNull()
        {
            MyFractionTestAssert.Throws<NullReferenceException>(() => new FractionConsoleApp.Fraction(null));
        }

        /// <summary>
        /// My own Fraction Assert to Test Exception
        /// </summary>
        public static class MyFractionTestAssert
        {
            public static void Throws<T>(Action func) where T : Exception
            {
                var exceptionThrown = false;
                try
                {
                    func.Invoke();
                }
                catch (T)
                {
                    exceptionThrown = true;
                }

                if (!exceptionThrown)
                {
                    throw new AssertFailedException(string.Format("An exception of type {0} was expected, but not thrown", typeof(T)));
                }
            }
        }

        /// <summary>
        /// This Test method will try will different entries for all operations
        /// </summary>
        [TestMethod]
        public void TestMethodOperationsWholeNumber()
        {
            FractionConsoleApp.Fraction Fraction1 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction Fraction2 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction Fraction3 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction Fraction4 = new FractionConsoleApp.Fraction();

            #region Test Set #1 Fraction Operation ( + )
            FractionConsoleApp.Fraction FractionPart1 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction FractionPart2 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction FractionPart3 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction FractionPart4 = new FractionConsoleApp.Fraction();
            FractionPart1 = new FractionConsoleApp.Fraction("3");
            FractionPart2 = new FractionConsoleApp.Fraction("1/8");
            Assert.AreEqual((FractionPart1 + FractionPart2).ToString(), "25/8");
            FractionPart3 = new FractionConsoleApp.Fraction("2");
            FractionPart4 = new FractionConsoleApp.Fraction("1/2");
            Assert.AreEqual((FractionPart3 + FractionPart4).ToString(), "5/2");

            Fraction1 = new FractionConsoleApp.Fraction("25/8");
            Fraction2 = new FractionConsoleApp.Fraction("5/2");
            Assert.AreEqual((FractionPart3 + FractionPart4).ToString(), "25/2");
            #endregion

            #region Test Set #1 Fraction Operation ( + )
            //Fraction1 = new FractionConsoleApp.Fraction("3");
            //Fraction2 = new FractionConsoleApp.Fraction("1/8");
            //Assert.AreEqual((Fraction1 + Fraction2).ToString(), "5/8");

            //Fraction2Part1 = new FractionConsoleApp.Fraction("5");
            //Fraction2Part2 = new FractionConsoleApp.Fraction("4/5");
            //Assert.AreEqual((Fraction2Part1 + Fraction2Part2).ToString(), "5/8");

            #endregion

        }

        /// <summary>
        /// This Test method will try will different entries for all operations
        /// </summary>
        [TestMethod]
        public void TestMethodOperations()
        {
            FractionConsoleApp.Fraction Fraction1 = new FractionConsoleApp.Fraction();
            FractionConsoleApp.Fraction Fraction2 = new FractionConsoleApp.Fraction();

            #region Test Set #1 Fraction Operation ( + )
            Fraction1 = new FractionConsoleApp.Fraction("1/8");
            Fraction2 = new FractionConsoleApp.Fraction("1/2");
            Assert.AreEqual((Fraction1 + Fraction2).ToString(), "5/8");

            Fraction1 = new FractionConsoleApp.Fraction("24/3");
            Fraction2 = new FractionConsoleApp.Fraction("11/5");
            Assert.AreEqual((Fraction1 + Fraction2).ToString(), "51/5");

            Fraction1 = new FractionConsoleApp.Fraction("21/22");
            Fraction2 = new FractionConsoleApp.Fraction("21/3");
            Assert.AreEqual((Fraction1 + Fraction2).ToString(), "175/22");
            #endregion

            #region Test Set #2 Fraction Operation ( - )
            Fraction1 = new FractionConsoleApp.Fraction("1/8");
            Fraction2 = new FractionConsoleApp.Fraction("2/5");
            Assert.AreEqual((Fraction1 - Fraction2).ToString(), "-11/40");

            Fraction1 = new FractionConsoleApp.Fraction("2/8");
            Fraction2 = new FractionConsoleApp.Fraction("4/5");
            Assert.AreEqual((Fraction1 - Fraction2).ToString(), "-11/20");

            Fraction1 = new FractionConsoleApp.Fraction("32/3");
            Fraction2 = new FractionConsoleApp.Fraction("28/5");
            Assert.AreEqual((Fraction1 - Fraction2).ToString(), "76/15");
            #endregion

            #region Test Set #2 Fraction Operation ( * )
            Fraction1 = new FractionConsoleApp.Fraction("3/5");
            Fraction2 = new FractionConsoleApp.Fraction("4/6");
            Assert.AreEqual((Fraction1 * Fraction2).ToString(), "2/5");

            Fraction1 = new FractionConsoleApp.Fraction("1/5");
            Fraction2 = new FractionConsoleApp.Fraction("4/7");
            Assert.AreEqual((Fraction1 * Fraction2).ToString(), "4/35");

            Fraction1 = new FractionConsoleApp.Fraction("2/8");
            Fraction2 = new FractionConsoleApp.Fraction("1/9");
            Assert.AreEqual((Fraction1 * Fraction2).ToString(), "1/36");
            #endregion

            #region Test Set #4 Fraction Operation ( / )
            Fraction1 = new FractionConsoleApp.Fraction("3/5");
            Fraction2 = new FractionConsoleApp.Fraction("4/6");
            Assert.AreEqual((Fraction1 / Fraction2).ToString(), "9/10");

            Fraction1 = new FractionConsoleApp.Fraction("13/5");
            Fraction2 = new FractionConsoleApp.Fraction("14/6");
            Assert.AreEqual((Fraction1 / Fraction2).ToString(), "39/35");

            Fraction1 = new FractionConsoleApp.Fraction("32/51");
            Fraction2 = new FractionConsoleApp.Fraction("41/16");
            Assert.AreEqual((Fraction1 / Fraction2).ToString(), "512/2091");
            #endregion
        }

        
    }
}
