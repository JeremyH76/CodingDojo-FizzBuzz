using CodingDojo_FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class UnitTestFooBarQix
    {

        [Fact]
        public void TestFooBarQix()
        {
            Assert.Equal("1", FooBarQix.Of(1));
            Assert.Equal("2", FooBarQix.Of(2));
            Assert.Equal("FooFoo", FooBarQix.Of(3));
            Assert.Equal("4", FooBarQix.Of(4));
            Assert.Equal("BarBar", FooBarQix.Of(5));
            Assert.Equal("Foo", FooBarQix.Of(6));
            Assert.Equal("QixQix", FooBarQix.Of(7));
            Assert.Equal("8", FooBarQix.Of(8));
            Assert.Equal("Foo", FooBarQix.Of(9));
            Assert.Equal("Bar", FooBarQix.Of(10));
            Assert.Equal("Foo", FooBarQix.Of(13));
            Assert.Equal("FooBarBar", FooBarQix.Of(15));
            Assert.Equal("FooQix", FooBarQix.Of(21));
            Assert.Equal("FooFooFoo", FooBarQix.Of(33));
            Assert.Equal("FooBar", FooBarQix.Of(51));
            Assert.Equal("BarFoo", FooBarQix.Of(53));
        }

    }
}
