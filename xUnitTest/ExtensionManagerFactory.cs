using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager manager = null;

        public static IExtensionManager Create()
        {
            if (manager != null)
                return manager;
            return new ExtensionManager();
        }

        public static void SetManagerAsStubs(IExtensionManager mngr)
        {
            manager = mngr;
        }


    }
}
