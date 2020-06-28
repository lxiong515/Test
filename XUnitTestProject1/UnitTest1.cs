using System;
using Xunit;
using FirstResponsiveWebAppXiong1.Models;
using FirstResponsiveWebAppXiong1;
using FirstResponsiveWebAppXiong1.Controllers;
using Microsoft.VisualStudio.TestPlatform;



namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            string Name = "John";
            int BirthYear = 1989;
            string expected = "John is 31 years old";
            string actual;
            //act
            actual = YearModel.AgeThisYear(Name, BirthYear);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
