using CodingDojo_FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class UnitTest2
    {
        [Fact]
        public void TestNext20First()
        {
            Assert.Equal("1", FizzBuzz2.Next(0));
            Assert.Equal("2", FizzBuzz2.Next(1));
            Assert.Equal("Fizz", FizzBuzz2.Next(2));
            Assert.Equal("4", FizzBuzz2.Next(3));
            Assert.Equal("Buzz", FizzBuzz2.Next(4));
            Assert.Equal("Fizz", FizzBuzz2.Next(5));
            Assert.Equal("7", FizzBuzz2.Next(6));
            Assert.Equal("8", FizzBuzz2.Next(7));
            Assert.Equal("Fizz", FizzBuzz2.Next(8));
            Assert.Equal("Buzz", FizzBuzz2.Next(9));
            Assert.Equal("11", FizzBuzz2.Next(10));
            Assert.Equal("Fizz", FizzBuzz2.Next(11));
            Assert.Equal("Fizz", FizzBuzz2.Next(12));
            Assert.Equal("14", FizzBuzz2.Next(13));
            Assert.Equal("FizzBuzz", FizzBuzz2.Next(14));
            Assert.Equal("16", FizzBuzz2.Next(15));
            Assert.Equal("17", FizzBuzz2.Next(16));
            Assert.Equal("Fizz", FizzBuzz2.Next(17));
            Assert.Equal("19", FizzBuzz2.Next(18));
            Assert.Equal("Buzz", FizzBuzz2.Next(19));
            Assert.Equal("Fizz", FizzBuzz2.Next(20));
        }

        [Fact]
        public void TestBigNumber()
        {
            Assert.Equal("FizzFizzBuzz", FizzBuzz2.Of(300));
            Assert.Equal("FizzFizzBuzz", FizzBuzz2.Of(300000000));
            Assert.Equal("FizzFizzFizz", FizzBuzz2.Of(300000003));
            Assert.Equal("Fizz", FizzBuzz2.Of(300000004));
            Assert.Equal("FizzBuzzBuzz", FizzBuzz2.Of(300000005));
        }

        [Fact]
        public void TestStage2()
        {
            Assert.Equal("FizzFizzBuzz", FizzBuzz2.Of(30));
            Assert.Equal("Fizz", FizzBuzz2.Of(31));
            Assert.Equal("Fizz", FizzBuzz2.Of(32));
            Assert.Equal("FizzFizzFizz", FizzBuzz2.Of(33));
            Assert.Equal("Fizz", FizzBuzz2.Of(34));
            Assert.Equal("FizzBuzzBuzz", FizzBuzz2.Of(35));
            Assert.Equal("FizzFizz", FizzBuzz2.Of(36));
            Assert.Equal("Fizz", FizzBuzz2.Of(37));
            Assert.Equal("Fizz", FizzBuzz2.Of(38));
            Assert.Equal("FizzFizz", FizzBuzz2.Of(39));
            Assert.Equal("Buzz", FizzBuzz2.Of(40));
            Assert.Equal("12467", FizzBuzz2.Of(12467));
            Assert.Equal("FizzBuzz", FizzBuzz2.Of(1234567));
        }

    }
}
