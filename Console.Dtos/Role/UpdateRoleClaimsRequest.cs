using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Role
{
    public class UpdateRoleClaimsRequest
    {
        public Guid RoleId { get; set; }
        public List<string> Claims { get; set; }
    }
}
