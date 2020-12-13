using GangOfFour.Patterns.Creational.AbstractFactory.Products;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    public class LondonOffice : IAbstractOffice
    {
        public IHumanResourcesDepartment CreateHumanResourcesDepartment()
        {
            return new HumanResourcesDepartmentLondon();
        }

        public IPurchasingDepartment CreatePurchasingDepartment()
        {
            return new PurchasingDepartmentLondon();
        }

        public ISecurityDepartment CreateSecurityDepartment()
        {
            return new SecurityDepartmentLondon();
        }
    }
}
