using CodingDojo_FizzBuzz;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestNext20First()
        {
            Assert.Equal("1",FizzBuzz.Next(0));
            Assert.Equal("2",FizzBuzz.Next(1));
            Assert.Equal("Fizz",FizzBuzz.Next(2));
            Assert.Equal("4",FizzBuzz.Next(3));
            Assert.Equal("Buzz",FizzBuzz.Next(4));
            Assert.Equal("Fizz",FizzBuzz.Next(5));
            Assert.Equal("7",FizzBuzz.Next(6));
            Assert.Equal("8",FizzBuzz.Next(7));
            Assert.Equal("Fizz",FizzBuzz.Next(8));
            Assert.Equal("Buzz",FizzBuzz.Next(9));
            Assert.Equal("11",FizzBuzz.Next(10));
            Assert.Equal("Fizz",FizzBuzz.Next(11));
            Assert.Equal("13",FizzBuzz.Next(12));
            Assert.Equal("14",FizzBuzz.Next(13));
            Assert.Equal("FizzBuzz",FizzBuzz.Next(14));
            Assert.Equal("16",FizzBuzz.Next(15));
            Assert.Equal("17",FizzBuzz.Next(16));
            Assert.Equal("Fizz",FizzBuzz.Next(17));
            Assert.Equal("19",FizzBuzz.Next(18));
            Assert.Equal("Buzz",FizzBuzz.Next(19));
            Assert.Equal("Fizz",FizzBuzz.Next(20));
        }
    }
}