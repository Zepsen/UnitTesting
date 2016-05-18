using System;
using NSubstitute;
using xUnitTest;
using Xunit;

namespace NSub
{
    
    public class ReturningValuesWithNSub
    {
        [Fact]
        public void TestMethod1()
        {
            var fake = Substitute.For<IExtensionManager>();

            fake.IsValidFile().Returns(true);

            Assert.True(fake.IsValidFile());
        }
    }
}
