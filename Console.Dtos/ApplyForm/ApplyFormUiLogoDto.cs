using System;
using System.IO;

namespace Skynet.Dtos.ApplyForm
{
    public class ApplyFormUiLogoDto
    {
        public Guid ApplyFormUiLogoId { get; set; }

        public Guid CompanyId { get; set; }

        public Stream Content { get; set; }

        public string ContentType { get; set; }
    }
}