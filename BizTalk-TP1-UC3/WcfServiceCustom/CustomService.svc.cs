using CSharpVitamins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCustom
{
    public class CustomService : ICustomService
    {
        public string GetUid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();

        }
        public string GetShortGuid()
        {
            ShortGuid shortGuid = new ShortGuid(Guid.NewGuid());
            return shortGuid.ToString();

        }

        public string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
