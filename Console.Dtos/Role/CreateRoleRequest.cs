using System;

namespace Skynet.Dtos.Role
{
    public class CreateRoleRequest : IBaseRoleDto
    {
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
    }
}
