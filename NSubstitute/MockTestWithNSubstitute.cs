using System;
using xUnitTest;
using Xunit;

namespace NSubstitute
{
    
    public class MockTestWithNSubstitute
    {
        [Fact]
        public void TestMetod()
        {
            //Arrange
            IWebService fake = Substitute.For<IWebService>();
            var log = new TestClassMock(fake);
            var str = "test";
            //Act
            log.Analyze(str);

            //Assert
            fake.Received().LogError("Too short: test");

        }
    }
}
