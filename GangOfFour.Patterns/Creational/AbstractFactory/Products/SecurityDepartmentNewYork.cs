using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Security department in New York has a specific access control to the building which is different from any other office.
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

        private void SetUpTwoFactorAuthentication(string employee) { }

        private void GeneratePassword(string employee) { }

        private void SetBuildingAccessBaseOnRole(string employee, JobTitles jobTitle) { }
    }
}