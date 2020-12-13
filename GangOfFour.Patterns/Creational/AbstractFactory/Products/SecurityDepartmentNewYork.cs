using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
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

        private void SetUpTwoFactorAuthentication(string employee) { }

        private void GeneratePassword(string employee) { }

        private void SetBuildingAccessBaseOnRole(string employee, JobTitles jobTitle) { }
    }
}