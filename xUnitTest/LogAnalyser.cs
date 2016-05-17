using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    //Ctor injection
    //public class LogAnalyser 
    //{
    //    IExtensionManager Manager;

    //    public LogAnalyser(IExtensionManager mngr)
    //    {
    //        Manager = mngr;
    //    }

    //    public bool IsValidationData()
    //    {
    //        return Manager.IsValidFile();
    //    }
    //}

    //Properties injection
    //public class LogAnalyser
    //{
    //    public IExtensionManager Manager { get; set; }

    //    public LogAnalyser()
    //    {
    //       // init real ExtensionManager 
    //       Manager = new ExtensionManager();
    //    }

    //    public bool IsValidationData()
    //    {
    //        return Manager.IsValidFile();
    //    }
    //}

    //injection Throug the Factory 
    public class LogAnalyser
    {
        public IExtensionManager Manager { get; set; }

        public LogAnalyser()
        {
            // init real ExtensionManager 
            Manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidationData()
        {
            return Manager.IsValidFile();
        }
    }
}
