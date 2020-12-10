using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public interface ISecurityDepartment
    {
        void RequestOfficeSecurityCredentials(string employee, JobTitles jobTitle);
    }
}