using FluentAssertions;
using IdeaWeightCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace IdealWeightCalculatorTest
{
    [TestClass]
    public class weightcalculatorTest
    {
        //name of the method :
        //Given_When_Then
        //method condition results 
        //[TestMethod]
        //public void GetIdealWeight_Height_176_gender_W_return_63()
        //{
        //    //arrange
        //    weightcalculator sut = new weightcalculator()
        //    {
        //        height = 176,
        //        gender = 'w'
        //    };
        //    //act
        //    double actual = sut.GetIdealWeight();
        //    double expected = 63;
        //    Console.WriteLine($"the total weight is : {actual}");

        //    //assert
        //    Assert.AreEqual( expected, actual );

        //} 
        //[TestMethod]
        //public void GetIdealWeight_Height_176_gender_m_return_65()
        //{
        //    //arrange
        //    weightcalculator sut = new weightcalculator()
        //    {
        //        height = 170,
        //        gender = 'm'
        //    };
        //    //act
        //    double actual = sut.GetIdealWeight();
        //    double expected = 65;
        //    Console.WriteLine($"the total weight is : {actual}");

        //    //assert
        //    Assert.AreEqual( expected, actual );
        //}

        //  [TestMethod]
        //public void Assert_test()
        //{
        //    //Assert.AreEqual(100, 100);
        //    //Assert.AreNotEqual(100, 100);

        //   // weightcalculator cal1 = new weightcalculator();
        //   // weightcalculator cal2 = new weightcalculator();

        //    // Assert.AreNotEqual(cal1, cal2);

        //    //cal2 = null;
        //    //Assert.IsNull(cal2);

        //   // Assert.IsFalse(100 == 200);
        //}

        //[TestMethod]
        //public void String_Assert_Test()
        //{
        //    string name = "Naira";
        //    StringAssert.Contains(name, "ra");
        //    StringAssert.EndsWith(name, "ra");
        //    StringAssert.StartsWith(name, "ra");
        //}

        [TestMethod]
        [Description("This is fluent assert test")]
        [Priority(1)]
        [Owner("yosra")]
        [TestCategory("UnitTest")]
        [Ignore]
        [Timeout(1)]
        public void Fluent_Assert_Test()
        {
            string name = "yosra";
            name.Should().StartWith("yo");
            name.Should().EndWith("ra");
            name.Should().Contain("os");

        }
    }
}
