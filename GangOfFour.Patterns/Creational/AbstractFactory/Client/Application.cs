using GangOfFour.Patterns.Creational.AbstractFactory.Factories;
using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;
using System.Collections.Generic;
using Xunit;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Client
{
    public class Application
    {
        /// <summary>
        /// The application code only knows it gets injected an abstract office and some input parameters.
        /// It doesn't really know which office is using neither what exactly the office is doing under the hood.
        /// </summary>
        
        [Theory]
        [MemberData(nameof(InjectDependencies))]
        public void ExampleAbstractFactory(IAbstractOffice office, string employee, JobTitles jobTitle)
        {
            var hrDepartment = office.CreateHumanResourcesDeparment();
            var securityDepartment = office.CreateSecurityDepartment();
            var purchasingDepartment = office.CreatePurchasingDepartment();

            hrDepartment.KickOffEmployeeOnboarding(employee);
            securityDepartment.RequestOfficeSecurityCredentials(employee, jobTitle);
            purchasingDepartment.RequestDeskSetup(jobTitle);
        }

        public static IEnumerable<object[]> InjectDependencies()
        {
            return new List<object[]>
            {
                new object[] { new LondonOffice(), "Richard Wood", JobTitles.Developer },
                new object[] { new NewYorkOffice(), "Rachel Smith", JobTitles.Director }
            };
        }
    }
}
