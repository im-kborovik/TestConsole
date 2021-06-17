using System;
using System.Text.RegularExpressions;
using Skynet.Dtos.Enums.Telephony;

namespace Skynet.Dtos.Telephony.Phone
{
    public class PhoneNumberDto
    {
        public Guid CompanyId { get; set; }
        private string _phoneNumber;

        
        

        public PhoneNumberProvider Provider { get; set; }
        public PhoneNumberType NumberType { get; set; }

        
        
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = Regex.Replace(value, "[^+0-9]", "");
        }



        public bool IsDeleted { get; set; }
    }
}