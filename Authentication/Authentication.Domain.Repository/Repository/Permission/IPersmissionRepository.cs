﻿using Authentication.Domain.Repository.Base;
using Authentication.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Domain.Repository.Repository.Permission
{
    public class PermissionRepository : BaseRepository<Entity.Permission>, IPermissionRepository
    {
        public PermissionRepository(AuthenticationContext _context) : base(_context)
        {


        }

    }
}
