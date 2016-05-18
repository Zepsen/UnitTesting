using System;
using NSubstitute;
using Xunit;
using xUnitTest;

namespace NSub
{
    
    public class MockTestWithNSub
    {
        [Fact]
        public void TestMethod1()
        {
            //Arrange
            IWebService fake = Substitute.For<IWebService>();
            var log = new TestClassMock(fake);
            var str = "test";
            //Act
            log.Analyze(str);

            //Assert-
            fake.Received().LogError("Too short: test");
        }
    }
}
