using System;
using xUnit.StubAndMockTest;
using xUnitTest.StubAndMock;
using Xunit;


namespace xUnit
{
    
    public class StubAndMock
    {
        [Fact]
        public void Test()
        {
            //Arrange
            FakeWebService stubWeb = new FakeWebService();
            stubWeb.ToThrow = new Exception("Fake exception");

            FakeEmailService mockEmail = new FakeEmailService();

            TestClassStubAndMock log = new TestClassStubAndMock(stubWeb, mockEmail);
            string testString = "test";

            //Act
            log.Analyze(testString);

            //Assert
            Assert.Contains("test@test.com", mockEmail.To);
            Assert.Contains("Fake exception", mockEmail.Body);
            Assert.Contains("can't log", mockEmail.Subject);

        }
    }
}
