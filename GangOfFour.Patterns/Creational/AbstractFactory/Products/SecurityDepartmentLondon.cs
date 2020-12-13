using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class SecurityDepartmentLondon : ISecurityDepartment
    {
        public void RequestOfficeSecurityCredentials(string employee, JobTitles jobTitle)
        {
            SetBuildingAccessBaseOnRole(employee, jobTitle);
            PrintOutCardKey(employee);
        }

        private void SetBuildingAccessBaseOnRole(string employee, JobTitles jobTitle) { }

        private void PrintOutCardKey(string employee) { }
    }
}
