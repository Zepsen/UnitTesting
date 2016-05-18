using System;
using xUnitTest;
using Xunit;


namespace xUnit
{
    
    public class Mock
    {
        [Fact]
        public void TestMethod1()
        {
            var mock = new FakeWebServise();
            var log = new TestClassMock(mock);
            var str = "test";
            
            log.Analyze(str);

            Assert.Contains("Too short: test", mock.LastError);

        }
    }

    internal class FakeWebServise : IWebService
    {
        public string LastError;

        void IWebService.LogError(string error)
        {
            LastError = error;
        }
    }
}
