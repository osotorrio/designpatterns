using GangOfFour.Patterns.Creational.AbstractFactory.Products;
using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    /// <summary>
    /// NewYorkOffice factory is only responsible for creating departments from the New York office
    /// </summary>
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
