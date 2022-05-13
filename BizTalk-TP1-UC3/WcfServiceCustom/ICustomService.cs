﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCustom
{
    [ServiceContract]
    public interface ICustomService
    {
        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        string GetUid();

        [OperationContract]
        string GetShortGuid();

        [OperationContract]
        void AddMoneyForQuotaWithUsername(float quota, string username);

        [OperationContract]
        void AddQuota(int nbrOfPrint, string username);
    }
}
