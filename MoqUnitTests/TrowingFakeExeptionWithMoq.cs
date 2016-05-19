using System;
using Moq;
using xUnitTest;
using xUnitTest.Interfaces;
using xUnitTest.StubAndMock;
using Xunit;

namespace MoqUnitTests
{ 
    public class TrowingFakeExeptionWithMoq
    {
        [Fact]
        public void TestMethod1()
        {
            var stub = new Mock<IWebService>();
            stub.Setup(x => x.LogError(It.IsAny<string>()))
                .Throws(new Exception("Fake exception"));

            var test = new TestClassMock(stub.Object);

            Assert.Throws<Exception>(() =>
                test.Analyze("test"));

        }
    }
}
