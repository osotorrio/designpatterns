using GangOfFour.Patterns.Creational.AbstractFactory.Products;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IAbstractOffice
    {
        IHumanResourcesDepartment CreateHumanResourcesDepartment();

        ISecurityDepartment CreateSecurityDepartment();

        IPurchasingDepartment CreatePurchasingDepartment();
    }
}
