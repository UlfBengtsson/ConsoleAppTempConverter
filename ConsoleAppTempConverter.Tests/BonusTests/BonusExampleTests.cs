using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace ConsoleAppTempConverter.Tests.BonusTests
{
    public class BonusExampleTests
    {
        // Example of using MemberData instead of InLineDate
        public static IEnumerable<object[]> DecimalTestData()
        {
            yield return new object[] {
                new List<decimal>() { 12.2m, 22.2m },   //numbers
                34.4m                                   //expected
            };
        }


        [Theory]
        [MemberData(nameof(DecimalTestData))]
        public void DecimalListTest(List<decimal> numbers, decimal expected)
        {
            //Arrange
            //MemberData will provide the date

            //Act - will just do simple addition math to sum all the values
            decimal result = numbers.Sum();//Linq has this nice sum method

            //Assert
            Assert.Equal(expected, result);
        }

        // if you want to run more then one set of data using MemberData
        public static IEnumerable<object[]> DecimalTestDataMany()
        {
            yield return new object[] {
                new List<decimal>() { 12.2m, 22.2m },   //numbers
                34.4m                                   //expected
            };

            yield return new object[] {
                new List<decimal>() { 54.3m, 2.9m },   //numbers
                57.2m                                   //expected
            };
        }

        [Theory]
        [MemberData(nameof(DecimalTestDataMany))]
        public void DecimalListManyTest(List<decimal> numbers, decimal expected)
        {
            //Arrange
            //MemberData will provide the date

            //Act - will just do simple addition math to sum all the values
            decimal result = numbers.Sum();//Linq has this nice sum method

            //Assert
            Assert.Equal(expected, result);
        }

        //----------------------------------------------------------------------
    }
}
