using System;
using Moq;
using xUnitTest;
using xUnitTest.Interfaces;
using xUnitTest.StubAndMock;
using Xunit;

namespace MoqUnitTests
{
    
    public class StubAndMockWithMoq
    {
        [Fact]
        public void TestMethod1()
        {
            var stubWeb = new Mock<IWebService>();
            var mockEmail = new Mock<IEmailService>();

            stubWeb.Setup(s => s.LogError(It.IsAny<string>()))
                .Throws(new Exception("Fake exception"));

            var log = new TestClassStubAndMock(stubWeb.Object, mockEmail.Object);

            log.Analyze("test");

            mockEmail.Verify(v => v.SendEmail(
                "test@test.com", "can't log", "Fake exception"));

        }
    }
}
