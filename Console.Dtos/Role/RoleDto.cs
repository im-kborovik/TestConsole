using System;

namespace Skynet.Dtos.Role
{
    public class RoleDto : IBaseRoleDto
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }
}
