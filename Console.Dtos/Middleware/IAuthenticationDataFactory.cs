using Skynet.Dtos.Company;
using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Middleware
{
    public interface IAuthenticationDataFactory
    {
        CompanyDto Company { get; set; }
        Guid userID { get; set; }
        Guid companyId { get; set; }
        Guid? OriginalUserId { get; }
        Guid? OriginalCompanyId { get; }
        List<string> Roles { get; set; }

        bool HasAccessToCompany(Guid otherCompanyId, bool isAllowGlobalCompanyAccess = false);
        void SetOriginalUser(string originalUserId, string originalCompanyId);
    }
}