﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest.Interfaces;

namespace xUnit.StubAndMockTest
{
    public class FakeEmailService : IEmailService
    {
        public string To;
        public string Subject;
        public string Body;

        public void SendEmail(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }
    }
}
