using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    #region Ctor injection
    public class TestClassStubCtor
    {
        IExtensionManager Manager;

        public TestClassStubCtor(IExtensionManager mngr)
        {
            Manager = mngr;
        }

        public bool IsValidationData()
        {
            return Manager.IsValidFile();
        }
    }
    #endregion



}
