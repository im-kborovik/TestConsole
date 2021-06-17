﻿using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationResidenceRequestDto
    {
        public Guid PersonId { get; set; }

        public DateTime? StartOfResidence { get; set; }

        public HousingType? HousingType { get; set; }

        public Guid? MortgageLenderId { get; set; }

        public bool IsTaxesIncluded { get; set; }

        public double? TaxesAmount { get; set; }

        public double? InsuranceAmount { get; set; }

        public string CurrentExpenseDescription { get; set; }

        public double? AmountOwed { get; set; }

        public double? AmountOfThePayment { get; set; }
        
        public double? MonthlyRentAmount { get; set; }

        public ApplicationAddressRequestDto Address { get; set; }
    }
}