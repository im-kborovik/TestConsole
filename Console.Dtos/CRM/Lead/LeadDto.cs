using System;
using Skynet.Dtos.Enums.CRM;

namespace Skynet.Dtos.CRM.Lead
{
    public class LeadDto
    {
        public bool IsDeleted { get; set; }
        public string LeadConduitLeadId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public DateTime LastModified { get; set; }
        public Guid? ModifiedByUserId { get; set; }
        public Guid LeadId { get; set; }
        public Guid LeadSourceId { get; set; }
        
        public string BlendAppId { get; set; }

        public string LeadSourceLeadType { get; set; }
        public string ExternalCRMContactId { get; set; }
        public string ExternalCRMId { get; set; }
        public string LeadProviderLeadId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? AssignedUserId { get; set; }
       
        public string EmployerCompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public ClientPhoneType? PhoneType { get; set; }
        public string PhoneNumber2 { get; set; }
        public string EmailAddress { get; set; }
        public string CoBorrowerFirstName { get; set; }
        public string CoBorrowerLastName { get; set; }
        public string CoBorrowerEmail { get; set; }
        public CreditRating? CreditRating { get; set; }
        public double? PropertyValue { get; set; }
        public double? FirstMortgageBalance { get; set; }
        public double? FirstMortgageRate { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public double? LoanCashOutAmount { get; set; }
        public double? LoanLTV { get; set; }
        public LoanPurpose? LoanPurpose { get; set; }
        public double? LoanDownPayment { get; set; }
        public bool? IsMilitary { get; set; }
        public bool? IsHomeFound { get; set; }
        public bool? IsCurrentFHALoan { get; set; }
        public bool? IsCurrentVALoan { get; set; }
        public RateType? DesiredRateType { get; set; } 
        public RateType? ExistingRateType { get; set; }
        public double? LoanAmount { get; set; }
        public OccupancyType? OccupancyType { get; set; }
        public PropertyType? PropertyType { get; set; }
        public bool? PurchaseAgreementSigned { get; set; }
        public bool? RecentlyTurnedDown { get; set; }
        public double? SecondMortgageBalance { get; set; }
        public double? SecondMortgageRate { get; set; }
        public LoanType? LoanType { get; set; }
        public double? LeadPrice { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string TimeToContact { get; set; }
        public bool WorkingWithRealtor { get; set; }
        public string RealtorName { get; set; }
        public string RealtorPhone { get; set; }
        public string RealtorEmail { get; set; }
        public int? CreditScore { get; set; }
        public decimal? ChosenRate { get; set; }
        public string LoanProgram { get; set; }
        
        public decimal? APR15 { get; set; }
        public decimal? Rate15 { get; set; }
        public decimal? Payment15 { get; set; }

        public decimal? APR20 { get; set; }
        public decimal? Rate20 { get; set; }
        public decimal? Payment20 { get; set; }

        public decimal? APR30 { get; set; }
        public decimal? Rate30 { get; set; }
        public decimal? Payment30 { get; set; }
        
        public decimal? LoanFees { get; set; }

        public string LoanNumber { get; set; }
    }
}
