using System;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationMilitaryRequestDto
    {
        public bool IsServedInMilitary { get; set; }

        public DateTime? CurrentlyServingDate { get; set; }

        public bool IsCurrentlyServing { get; set; }

        public bool IsCurrentlyRetired { get; set; }

        public bool IsNonActivatedMemberOfReserveNationalGuard { get; set; }

        public bool IsSurvivingSpouse { get; set; }
    }
}