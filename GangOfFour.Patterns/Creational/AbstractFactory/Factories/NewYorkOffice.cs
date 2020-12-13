using GangOfFour.Patterns.Creational.AbstractFactory.Products;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    public class NewYorkOffice : IAbstractOffice
    {
        public IHumanResourcesDepartment CreateHumanResourcesDepartment()
        {
            return new HumanResourcesDepartmentNewYork();
        }

        public IPurchasingDepartment CreatePurchasingDepartment()
        {
            return new PurchasingDepartmentNewYork();
        }

        public ISecurityDepartment CreateSecurityDepartment()
        {
            return new SecurityDepartmentNewYork();
        }
    }
}
