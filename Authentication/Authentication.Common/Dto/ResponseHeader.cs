﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authentication.Common.DTO
{
    [DataContract]
    public class ResponseHeader
    {
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string responseCode { get; set; }

        [DataMember]
        public string message { get; set; }



    }
}