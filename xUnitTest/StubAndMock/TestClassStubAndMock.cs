using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest.Interfaces;

namespace xUnitTest.StubAndMock
{
    class TestClassStubAndMock
    {
        IWebService WebService { get; set; }
        IEmailService EmailService { get; set; }

        public TestClassStubAndMock(IWebService ws, IEmailService es)
        {
            WebService = ws;
            EmailService = es;
        }

        public void Analyze(string str)
        {
            if (str.Length < 8)
            {
                try
                {
                    WebService.LogError("Too short: " + str);
                }
                catch (Exception ex)
                {
                    //Testing 
                    EmailService.SendEmail("test@test.com", "can't log", ex.Message);
                }
            }
        }

    }
}
