using System;
using Moq;
using xUnitTest;
using Xunit;

namespace MoqUnitTests
{
    public class ReturningValuesWithMoq
    {
        [Fact]
        public void TestMethod1()
        {
            var stubMoq = new Mock<IExtensionManager>();
            stubMoq.Setup(x => x.IsValidFile()).Returns(true);

            var test = new TestClassStubCtor(stubMoq.Object);

            Assert.True(test.IsValidationData());
        }
    }
}
