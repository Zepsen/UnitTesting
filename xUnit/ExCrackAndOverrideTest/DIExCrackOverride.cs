using System;
using xUnitTest;
using Xunit;

namespace xUnit
{
    
    public class ExCrackOverride
    {
        [Fact]
        public void ExCrackAndOverrideTest()
        {
            var fake = new FakeExtensionManager();
            var testable = new TestableFakeLogAnayser(fake);

            Assert.False(testable.IsValidationData());
        }
    }

    internal class TestableFakeLogAnayser : TestClassExCrackAndOverride
    {
        IExtensionManager manager;

        public TestableFakeLogAnayser(IExtensionManager mng)
        {
            manager = mng;
        }

        protected override IExtensionManager GetManager()
        {
            return manager;
        }
    }
}
