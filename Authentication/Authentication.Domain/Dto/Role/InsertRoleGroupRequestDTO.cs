﻿using Authentication.Common.DTO;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authentication.Domain.Dto.Role
{
    [DataContract]
    public class InsertRoleGroupRequestDTO : RequestDTOBase
    {
        [DataMember]
        public long RoleID { get; set; }
        [DataMember]
        public long GroupID { get; set; }
    }
}
