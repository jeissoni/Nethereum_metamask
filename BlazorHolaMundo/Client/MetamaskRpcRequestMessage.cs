﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client.RpcMessages;
using Newtonsoft.Json;

namespace BlazorHolaMundo.Client
{
    public class MetamaskRpcRequestMessage : RpcRequestMessage
    {

        public MetamaskRpcRequestMessage(object id, string method, string from, params object[] parameterList) : base(id, method,
            parameterList)
        {
            From = from;
        }

        [JsonProperty("from")]
        public string From { get; private set; }
    }
}
