using System;
using xUnitTest;
using Xunit;


namespace xUnit
{
    [Trait("Through the factory", "DI")]
    public class StubThroughTheFactory
    {
        [Fact]
        public void TestMethod1()
        {
            ExtensionManagerFactory.SetManagerAsStubs(
                new FakeExtensionManager());

            var log = new TestClassStubFactory();

            Assert.False(log.IsValidationData());
        }
    }
}
