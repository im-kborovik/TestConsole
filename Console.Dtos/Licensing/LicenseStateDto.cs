using System;

namespace Skynet.Dtos.Licensing
{
    public class LicenseStateDto
    {
        public string StateCode { get; set; }
        public DateTime LicenseStartDate { get; set; }
        public DateTime LicenseExpireDate { get; set; }
        public string StateLicenseNumber { get; set; }
        public Guid UserId { get; set; }

    }
}
