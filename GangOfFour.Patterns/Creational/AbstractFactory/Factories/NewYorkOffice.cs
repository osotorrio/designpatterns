using GangOfFour.Patterns.Creational.AbstractFactory.Products;
using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    public class NewYorkOffice : IAbstractOffice
    {
        public IHumanResourcesDepartment CreateHumanResourcesDeparment()
        {
            return new HumanResourcesNewYork();
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
