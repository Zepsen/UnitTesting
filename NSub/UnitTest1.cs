using System;
using NSubstitute;
using xUnitTest.Events;
using xUnitTest.Interfaces;
using Xunit;

namespace NSub
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var fakeView = Substitute.For<IViewEvent>();
            var testClass = new TestClassEvents(fakeView);

            //Generate event
            fakeView.Loaded += Raise.Event<Action>();

            fakeView.Received().Render(Arg.Is<string>(
                s => s.Contains("Test")));

        }
    }
}
