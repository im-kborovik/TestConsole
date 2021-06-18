using System;
using System.Collections.Generic;
using Skynet.Dtos.ApplyForm.Application;
using Skynet.Shared.Loan.LoanApplication;

namespace TestConsole
{
    public static class ApplicationHelper
    {
        public static ApplicationDto GetFormTemplateViewModelStub()
        {
            return new()
                   {
                       ApplicationId = Guid.Empty,
                       ClientId = null,
                       CompanyId = Guid.Empty,
                       Status = ApplicationStatus.FirstPartApproved,
                       LoanPurpose = LoanPurpose.Purchase,
                       DateCreated = DateTime.Now,
                       LastModified = DateTime.Now,
                       LoanId = null,
                       FirstMortgageBalance = 10000,
                       IsConsentObtained = false,
                       SecondMortgageBalance = 20000,
                       IsAuthorizedToContact = true,
                       IsSecondMortgageObtained = true,
                       SubjectProperty = new ApplicationSubjectPropertyDto
                                         {
                                             PropertyType = PropertyType.Condo,
                                             CondoAssociationName = "Condo1",
                                             PropertyValue = 3,
                                             Address = new ApplicationAddressDto
                                                       {
                                                           Country = "United State",
                                                           City = "Chicago",
                                                           State = "Illinois",
                                                           Zip = "60603",
                                                           Street = "Test",
                                                           Unit = "42"
                                                       },
                                             Occupancy = OccupancyType.InvestmentProperty,
                                             CondoAssociationDues = 3.88
                                         },
                       Borrowers = new List<ApplicationBorrowerDto>
                                   {
                                       new()
                                       {
                                           IsLivedSameTwoYears = true,
                                           Person = new ApplicationPersonDto
                                                    {
                                                        IsLiveTogether = true,
                                                        FirstName = "John1",
                                                        Declarations = new ApplicationDeclarationDto
                                                                       {
                                                                           Sex = Sex.Male,
                                                                           UsCitizen = true
                                                                       },
                                                        Incomes = new List<ApplicationIncomeDto>
                                                                  {
                                                                      new()
                                                                      {
                                                                          MonthlyIncome = 8000
                                                                      },
                                                                      new()
                                                                      {
                                                                          MonthlyIncome = 5000
                                                                      }
                                                                  }
                                                    },
                                           SpousePerson = new ApplicationPersonDto
                                                          {
                                                              FirstName = "SpouseName1",
                                                              Declarations = new ApplicationDeclarationDto
                                                                             {
                                                                                 Sex = Sex.Female,
                                                                                 UsCitizen = true
                                                                             },
                                                              Incomes = new List<ApplicationIncomeDto>
                                                                        {
                                                                            new()
                                                                            {
                                                                                MonthlyIncome = 6000
                                                                            },
                                                                            new()
                                                                            {
                                                                                MonthlyIncome = 4500
                                                                            }
                                                                        }
                                                          }
                                       },
                                       new()
                                       {
                                           IsLivedSameTwoYears = true,
                                           Person = new ApplicationPersonDto
                                                    {
                                                        FirstName = "John2",
                                                        Declarations = new ApplicationDeclarationDto
                                                                       {
                                                                           Sex = Sex.Male,
                                                                           UsCitizen = true
                                                                       },
                                                        Incomes = new List<ApplicationIncomeDto>
                                                                  {
                                                                      new()
                                                                      {
                                                                          MonthlyIncome = 8000
                                                                      },
                                                                      new()
                                                                      {
                                                                          MonthlyIncome = 5000
                                                                      }
                                                                  }
                                                    },
                                           SpousePerson = new ApplicationPersonDto
                                                          {
                                                              FirstName = "SpouseName2",
                                                              Declarations = new ApplicationDeclarationDto
                                                                             {
                                                                                 Sex = Sex.Female,
                                                                                 UsCitizen = true
                                                                             },
                                                              Incomes = new List<ApplicationIncomeDto>
                                                                        {
                                                                            new()
                                                                            {
                                                                                MonthlyIncome = 6000
                                                                            },
                                                                            new()
                                                                            {
                                                                                MonthlyIncome = 4500
                                                                            }
                                                                        }
                                                          }
                                       }
                                   }
                   };
        }
    }
}