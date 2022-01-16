using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SecurityDepartmentLondon : ISecurityDepartment
    {
        public void RequestOfficeSecurityCredentials(string employee, JobTitles jobTitle)
        {
            SetBuildingAccessBaseOnRole(employee, jobTitle);
            PrintOutCardKey(employee);
        }

        private static void SetBuildingAccessBaseOnRole(string employee, JobTitles jobTitle) { }

        private static void PrintOutCardKey(string employee) { }
    }
}
