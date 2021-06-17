using System;
using System.Collections.Generic;
using Skynet.Dtos.User;

namespace Skynet.Dtos.Company
{
    public class CompanyDto
    {
        public Guid CompanyId { get; set; }

        public string Name { get; set; }

        public bool Approved { get; set; }

    }
}
