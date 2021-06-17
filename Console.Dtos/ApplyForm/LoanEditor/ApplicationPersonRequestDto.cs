using System;
using System.Runtime.Serialization;
using Skynet.Shared.ApplyForm;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationPersonRequestDto
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public PersonSuffix? Suffix { get; set; }

        public string CellPhoneNumber { get; set; }

        public string HomePhoneNumber { get; set; }

        public string WorkPhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public MaritalStatus? MaritalStatus { get; set; }
        
        public CitizenshipStatus? CitizenshipStatus { get; set; }

        public string SocialSecurityNumber { get; set; }

        public bool? IsLiveTogether { get; set; }

        public bool? IsLiveTogetherForTwoYears { get; set; }
        
        public bool? IsSameResidencesAsForPerson { get; set; }
        
        public int? NumberOfDependents { get; set; }
        
        public string AgeOfDependents { get; set; }
        
        public bool? IsFirstTimeHomeBuyer { get; set; }
    }
    
    public enum PersonSuffix
    {
        [EnumMember(Value = "Jr.")] Jr,
        [EnumMember(Value = "Sr.")] Sr,
        [EnumMember(Value = "JD")] Jd,
        [EnumMember(Value = "M.Ed.")] MEd,
        PhD,
        I,
        [EnumMember(Value = "II")] Ii,
        [EnumMember(Value = "III")] Iii,
        [EnumMember(Value = "IV")] Iv,
        None
    }

}