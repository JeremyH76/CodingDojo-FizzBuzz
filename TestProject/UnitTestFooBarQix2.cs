using CodingDojo_FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class UnitTestFooBarQix2
    {

        [Fact]
        public void TestFooBarQixWith0()
        {
            Assert.Equal("1", FooBarQix2.Of(1));
            Assert.Equal("2", FooBarQix2.Of(2));
            Assert.Equal("FooFoo", FooBarQix2.Of(3));
            Assert.Equal("4", FooBarQix2.Of(4));
            Assert.Equal("BarBar", FooBarQix2.Of(5));
            Assert.Equal("Foo", FooBarQix2.Of(6));
            Assert.Equal("QixQix", FooBarQix2.Of(7));
            Assert.Equal("8", FooBarQix2.Of(8));
            Assert.Equal("Foo", FooBarQix2.Of(9));
            Assert.Equal("Bar*", FooBarQix2.Of(10));
            Assert.Equal("Foo", FooBarQix2.Of(13));
            Assert.Equal("FooBarBar", FooBarQix2.Of(15));
            Assert.Equal("FooQix", FooBarQix2.Of(21));
            Assert.Equal("FooFooFoo", FooBarQix2.Of(33));
            Assert.Equal("FooBar", FooBarQix2.Of(51));
            Assert.Equal("BarFoo", FooBarQix2.Of(53));
        }

        [Fact]
        public void TestStarNumbers()
        {
            Assert.Equal("1*1", FooBarQix2.Of(101));
            Assert.Equal("FooFoo*Foo", FooBarQix2.Of(303));
            Assert.Equal("FooBarQix*Bar", FooBarQix2.Of(105));
            Assert.Equal("FooQix**", FooBarQix2.Of(10101));
        }

    }
}
