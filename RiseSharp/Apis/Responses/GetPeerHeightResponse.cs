﻿using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetPeerHeightResponse : BaseApiResponse
    {
        [DataMember(Name = "height")]
        public long Height { get; set; }
    }
}
