using GangOfFour.Patterns.Creational.AbstractFactory.Products;
using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Factories
{
    /// <summary>
    /// LondonOffice factory is only responsible for creating departments from the London office
    /// </summary>
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
