using System;
using NSubstitute;
using xUnitTest;
using xUnitTest.Interfaces;
using xUnitTest.StubAndMock;
using Xunit;
using Xunit.Sdk;


namespace NSub
{
    public class StubAndMockWithNSub
    {
        [Fact]
        public void TestMethod1()
        {
            var webFake = Substitute.For<IWebService>();
            var emailFake = Substitute.For<IEmailService>();

            webFake.When(e => e.LogError(Arg.Any<string>()))
                    .Do(i =>
                    {
                        throw new Exception("Fake exception");
                    });

            var log = new TestClassStubAndMock(webFake, emailFake);

            log.Analyze("test");

            emailFake.Received().SendEmail(
                Arg.Is<string>(s => s.Contains("test@test.com")),
                Arg.Is<string>(s => s.Contains("can't log")),
                Arg.Is<string>(s => s.Contains("Fake exception")));
        }
    }
}
