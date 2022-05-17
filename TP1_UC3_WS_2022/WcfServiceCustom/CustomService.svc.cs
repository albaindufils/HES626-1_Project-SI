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
        public int GetRandomValue()
        {
            var rand = new Random();
            return rand.Next(101);
        }
    }
}
