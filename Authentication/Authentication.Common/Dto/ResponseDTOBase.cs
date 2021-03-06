﻿
using Authentication.Common.Constants;
using System.Runtime.Serialization;

namespace Authentication.Common.DTO
{
    [DataContract]
    public class ResponseDTOBase
    {
        public ResponseDTOBase()
        {
            this.responseInfo = new ResponseInfo
            {
                responseCode = ResponseCode.Success,
                IsSuccess = true,
                message = "Success"


            };

            this.dataInfo = new ResponseDataInfo
            {
                TotalCount = 0
            };
        }

        [DataMember]
        public ResponseInfo responseInfo { get; set; }

        [DataMember]
        public ResponseDataInfo dataInfo { get; set; }
    }
}