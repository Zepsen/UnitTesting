using System;
using xUnitTest;
using Xunit;


namespace xUnit
{
    [Trait("Through the factory", "DI")]
    public class DIThroughTheFactory
    {
        [Fact]
        public void TestMethod1()
        {
            ExtensionManagerFactory.SetManagerAsStubs(
                new FakeExtensionManager());

            var log = new LogAnalyser();

            Assert.False(log.IsValidationData());
        }
    }
}
