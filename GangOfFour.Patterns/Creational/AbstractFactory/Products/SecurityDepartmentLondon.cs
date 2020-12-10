using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class SecurityDepartmentLondon : ISecurityDepartment
    {
        public void RequestOfficeSecurityCredentials(string employee, JobTitles jobTitle)
        {
            throw new NotImplementedException();
        }
    }
}
