using System;
using Moq;
using xUnitTest.Events;
using xUnitTest.Interfaces;
using Xunit;

namespace MoqUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var stub = new Mock<IViewEvent>();
            var testClass = new TestClassEvents(stub.Object);

            stub.Raise(x => x.Loaded += null);
            stub.Verify(x => x.Render("Test"));
            

        }
    }
}
