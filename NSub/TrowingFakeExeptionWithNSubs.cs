using System;
using NSubstitute;
using xUnitTest;
using xUnitTest.Interfaces;
using Xunit;

namespace NSub
{
    public class TrowingFakeExeptionWithNSubs
    {
        [Fact]
        public void TestMethod1()
        {
            var fake = Substitute.For<IWebService>();
            fake.When(i => i.LogError(Arg.Any<string>()))
                .Do(context =>
                {
                    throw new Exception("Fake exeption");
                });

            Assert.Throws<Exception>(() => fake.LogError("str"));
        }
    }
}
