using System;

namespace Skynet.Dtos.Role
{
    public interface IBaseRoleDto
    {
        Guid CompanyId { get; }
        string Name { get; }
    }
}
