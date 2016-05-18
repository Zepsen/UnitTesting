using System;
using xUnitTest;
using Xunit;
using Xunit.Abstractions;

namespace xUnit
{
    [Trait("Through the property", "DI")]
    public class StubTroughThePropertyTest
    {
        [Fact]
        public void IsValidationDataFalse()
        {
            var log = new TestClassStubProperties
            {
                Manager = new FakeExtensionManager()
            };

            Assert.False(log.IsValidationData());
        }
    }
}
