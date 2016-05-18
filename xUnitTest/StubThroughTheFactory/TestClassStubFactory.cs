using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    #region injection Throug the Factory 
    public class TestClassStubFactory
    {
        public IExtensionManager Manager { get; set; }

        public TestClassStubFactory()
        {
            // init real ExtensionManager 
            Manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidationData()
        {
            return Manager.IsValidFile();
        }
    }
    #endregion
}
