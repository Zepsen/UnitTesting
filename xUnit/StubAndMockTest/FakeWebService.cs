using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest;

namespace xUnit.StubAndMockTest
{
    public class FakeWebService : IWebService
    {
        public Exception ToThrow { get; set; }

        public void LogError(string message)
        {
            //generation throw as stub
            if (ToThrow != null)
            {
                throw ToThrow;
            }
        }
    }
}
