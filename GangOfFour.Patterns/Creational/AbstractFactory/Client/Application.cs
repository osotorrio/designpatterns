using GangOfFour.Patterns.Creational.AbstractFactory.Factories;
using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;
using Xunit;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Client
{
    public class Application
    {
        [Theory]
        [InlineData("Richard Wood", JobTitles.Developer, OfficeLocations.London)]
        [InlineData("Rachel Smith", JobTitles.Director, OfficeLocations.NewYork)]
        public void ExampleAbstractFactory(string employee, JobTitles jobTitle, OfficeLocations location)
        {
            IAbstractOffice office = null;

            if (OfficeLocations.London == location)
            {
                office = new LondonOffice();
            }

            if (OfficeLocations.NewYork == location)
            {
                office = new NewYorkOffice();
            }

            var hrDepartment = office.CreateHumanResourcesDeparment();
            var securityDepartment = office.CreateSecurityDepartment();
            var purchasingDepartment = office.CreatePurchasingDepartment();

            hrDepartment.KickOffEmployeeOnboarding(employee);
            securityDepartment.RequestOfficeSecurityCredentials(employee, jobTitle);
            purchasingDepartment.RequestLaptopSetup(jobTitle);
        }
    }
}
