using System;
using System.Security.Cryptography;

using xUnitTest;
using Xunit;


namespace xUnit
{
    [Trait("Through the constructor", "DI")]
    public class StubThroughCtorTest
    {
        [Fact]
        public void IsValidationDataFalse()
        {
            var fakeManager = new FakeExtensionManager();
            var log = new TestClassStubCtor(fakeManager);

            bool result = log.IsValidationData();
            Assert.False(result);
        }
    }
}
