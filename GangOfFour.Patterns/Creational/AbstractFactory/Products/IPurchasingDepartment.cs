using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public interface IPurchasingDepartment
    {
        void RequestDeskSetup(JobTitles jobTitle);
    }
}