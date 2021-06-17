using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Scriban;
using Scriban.Runtime;
using Skynet.Dtos.ApplyForm.Application;
using Skynet.Forms.Services;
using Skynet.Shared.Loan.LoanApplication;

namespace TestConsole
{
    public class Tester
    {
        private bool _writeResult = true;
        private static readonly FormsDynamicFieldsService _dynamicService = new();

        private string TemplateBase { get; }

        private static ApplicationDto Model { get; } = GetFormTemplateViewModelStub();

        public static string GetTemplate()
        {
            var scheme = _dynamicService.GetScheme();

            return string.Join("\n",
                               scheme.Select(q => "<span data-dynamic-type=\"" + q.Type + "\" data-dynamic-value=\"" + q.Field + "\">" + q.Title + "</span>"));
        }

        public Tester(bool writeTemplate = true)
        {
            if (!writeTemplate)
            {
                return;
            }

            TemplateBase = GetTemplate();

            WriteLine("Base Template");
            Underline();
            WriteLine(TemplateBase);
        }

        public Tester(string template)
        {
            TemplateBase = template;
        }

        public Tester SetWriteResult()
        {
            _writeResult = true;

            return this;
        }

        public Tester SetNotWriteResult()
        {
            _writeResult = false;

            return this;
        }

        public Tester RenderByScriban()
        {
            var scriptObj = new ScriptObject
                            {
                                ["Application"] = Model
                            };

            var context = new TemplateContext
                          {
                              EnableRelaxedTargetAccess = true,
                              MemberRenamer = q => q.Name
                          };

            context.PushGlobal(scriptObj);

            var template = Template.Parse(TemplateBase);
            var result = template.Render(context);

            TryWriteResult(result);

            return this;
        }

        public Tester Underline()
        {
            return WriteLine(new string('-', 20));
        }

        public Tester WriteLine(string message)
        {
            Console.WriteLine(message);

            return this;
        }

        public Tester WriteTemplate()
        {
            Console.WriteLine(TemplateBase);

            return this;
        }

        private void TryWriteResult(string result)
        {
            if (_writeResult)
            {
                WriteLine(result);
            }
        }

        private static T Bench<T>(string benchName, Func<T> func)
        {
            var watcher = Stopwatch.StartNew();

            var result = func();

            watcher.Stop();

            Console.WriteLine($"{benchName}: {watcher.Elapsed.Seconds}s and {watcher.Elapsed.TotalMilliseconds}ms");

            return result;
        }

        private static ApplicationDto GetFormTemplateViewModelStub()
        {
            return new ApplicationDto
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
                                       new ApplicationBorrowerDto()
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
                                                                      new ApplicationIncomeDto()
                                                                      {
                                                                          MonthlyIncome = 8000
                                                                      },
                                                                      new ApplicationIncomeDto()
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
                                                                            new ApplicationIncomeDto()
                                                                            {
                                                                                MonthlyIncome = 6000
                                                                            },
                                                                            new ApplicationIncomeDto()
                                                                            {
                                                                                MonthlyIncome = 4500
                                                                            }
                                                                        }
                                                          }
                                       },
                                       new ApplicationBorrowerDto()
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
                                                                      new ApplicationIncomeDto()
                                                                      {
                                                                          MonthlyIncome = 8000
                                                                      },
                                                                      new ApplicationIncomeDto()
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
                                                                            new ApplicationIncomeDto()
                                                                            {
                                                                                MonthlyIncome = 6000
                                                                            },
                                                                            new ApplicationIncomeDto()
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

    public class FormTemplateViewModel
    {
        public ApplicationDto Application { get; set; }
    }
}