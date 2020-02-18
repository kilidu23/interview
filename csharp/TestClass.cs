using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace interview
{
    public class TestClass
    {
        [Fact]
        public void Testiramo()
        {
            var x = 3;
            Assert.Equal(2, x); 
        }
    }
}
