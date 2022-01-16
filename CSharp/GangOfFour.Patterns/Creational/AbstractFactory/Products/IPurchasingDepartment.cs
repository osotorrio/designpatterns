using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IPurchasingDepartment
    {
        void RequestDeskSetup(JobTitles jobTitle);
    }
}