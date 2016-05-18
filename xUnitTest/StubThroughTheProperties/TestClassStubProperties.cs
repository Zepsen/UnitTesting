using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{

    #region Properties injection
    public class TestClassStubProperties
    {
        public IExtensionManager Manager { get; set; }

        public TestClassStubProperties()
        {
            // init real ExtensionManager 
            Manager = new ExtensionManager();
        }

        public bool IsValidationData()
        {
            return Manager.IsValidFile();
        }
    }
    #endregion


}
