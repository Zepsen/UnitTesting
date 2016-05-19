using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest.Interfaces;

namespace xUnitTest.Events
{
    public class TestClassEvents
    {
        private readonly IViewEvent view;

        public TestClassEvents(IViewEvent v)
        {
            view = v;
            view.Loaded += OnLoaded;
        }

        private void OnLoaded()
        {
            view.Render("Test");
        }
    }
}
