using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCustom
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class CustomService : ICustomService
    {
        public string GetUid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
            
        }

        public string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
