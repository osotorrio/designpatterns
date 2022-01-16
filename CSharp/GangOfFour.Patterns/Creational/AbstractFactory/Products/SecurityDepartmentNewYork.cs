using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SecurityDepartmentNewYork : ISecurityDepartment
    {
        public void RequestOfficeSecurityCredentials(string employee, JobTitles jobTitle)
        {
            SetBuildingAccessBaseOnRole(employee, jobTitle);
            GeneratePassword(employee);

            if (JobTitles.Director == jobTitle)
            {
                SetUpTwoFactorAuthentication(employee);
            }
        }

        private static void SetUpTwoFactorAuthentication(string employee) { }

        private static void GeneratePassword(string employee) { }

        private static void SetBuildingAccessBaseOnRole(string employee, JobTitles jobTitle) { }
    }
}