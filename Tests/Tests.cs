using Greeter;
using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void SayHiTest()
        {
            Assert.Equal("Hello World", GreeterClass.SayHi());
        }
    }
}
