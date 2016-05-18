using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    #region Fake factory method ex-crack and override
    internal class TestClassExCrackAndOverride
    {
        public bool IsValidationData()
        {
            return GetManager().IsValidFile();
        }

        protected virtual IExtensionManager GetManager()
        {
            return new ExtensionManager();
        }
    }
    #endregion

     
}
