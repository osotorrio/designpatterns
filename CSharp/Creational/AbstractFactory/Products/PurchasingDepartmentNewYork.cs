using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class PurchasingDepartmentNewYork : IPurchasingDepartment
    {
        public void RequestDeskSetup(JobTitles jobTitle)
        {
            if (JobTitles.Developer == jobTitle)
            {
                PurchaseMobileWorkStation();
                RequestTwoMonitors();
            }

            if (JobTitles.Director == jobTitle)
            {
                PurchaseStandardLaptop();
                RequestOneMonitor();
            }
        }

        private static void PurchaseMobileWorkStation() { }

        private static void RequestTwoMonitors() { }

        private static void PurchaseStandardLaptop() { }

        private static void RequestOneMonitor() { }
    }
}
