using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest;

namespace xUnit
{
    internal class FakeExtensionManager : IExtensionManager
    {
        public bool IsValidFile()
        {
            return false;
        }
    }
}
 