using System;
using xUnitTest;
using Xunit;
using Xunit.Abstractions;

namespace xUnit
{
    [Trait("Through the property", "DI")]
    public class DITroughThePropertyTest
    {
        [Fact]
        public void IsValidationDataFalse()
        {
            var log = new LogAnalyser
            {
                Manager = new FakeExtensionManager()
            };
             
            Assert.False(log.IsValidationData());
        }
    }
}
