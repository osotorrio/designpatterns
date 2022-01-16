using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface ISecurityDepartment
    {
        void RequestOfficeSecurityCredentials(string employee, JobTitles jobTitle);
    }
}