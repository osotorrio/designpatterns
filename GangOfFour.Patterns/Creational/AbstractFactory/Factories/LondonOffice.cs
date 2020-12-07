using GangOfFour.Patterns.Creational.AbstractFactory.Products;
using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    public class LondonOffice : IAbstractOffice
    {
        public IHumanResourcesDepartment CreateHumanResourcesDeparment()
        {
            return new HumanResourcesLondon();
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
