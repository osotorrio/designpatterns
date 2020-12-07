using GangOfFour.Patterns.Creational.AbstractFactory.Products;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    public interface IAbstractOffice
    {
        IHumanResourcesDepartment CreateHumanResourcesDeparment();

        ISecurityDepartment CreateSecurityDepartment();

        IPurchasingDepartment CreatePurchasingDepartment();
    }
}
