using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    internal class TestClassMock
    {
        IWebService webService;

        public TestClassMock(IWebService iservice)
        {
            webService = iservice;
        }

        public void Analyze(string str)
        {
            if (str.Length < 8)
            {
                webService.LogError("Too short: " + str);
            }
        }


    }
}
