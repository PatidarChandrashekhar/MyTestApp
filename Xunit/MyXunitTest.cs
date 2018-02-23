using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using MyTestApp;

namespace Xunit
{
    public class MyXunitTest
    {
        [Fact]
        public void TestMethod()
        {
            //Arrange
            Calculator c = new Calculator();
            //Act
            var result = c.add(5,6);
            //Assert
            Assert.Equal(11, result);
        }
    }
}
