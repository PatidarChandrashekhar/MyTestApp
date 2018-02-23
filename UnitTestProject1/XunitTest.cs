using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using MyTestApp;

namespace XUnit
{

    public class XunitTest
    {
        [Fact]
        public void TestMethod1()
        {
            //XunitTest
            Calculator c = new Calculator();
            //Act
            var result = c.add(5, 6);
            //Assert
            Xunit.Assert.Equal(11, result);
        }
    }
}
