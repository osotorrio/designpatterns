using GangOfFour.Patterns.Creational.AbstractFactory.Products;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    public interface IAbstractOffice
    {
        IHumanResourcesDepartment CreateHumanResourcesDepartment();

        ISecurityDepartment CreateSecurityDepartment();

        IPurchasingDepartment CreatePurchasingDepartment();
    }
}
