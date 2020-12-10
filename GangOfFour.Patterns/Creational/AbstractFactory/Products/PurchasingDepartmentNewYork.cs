using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class PurchasingDepartmentNewYork : IPurchasingDepartment
    {
        public void RequestLaptopSetup(JobTitles jobTitle)
        {
            if (JobTitles.Developer == jobTitle)
            {
                BuyMobileWorkStation();
                RequestTwoMonitors();
            }

            if (JobTitles.Director == jobTitle)
            {
                BuyLaptop();
                RequestOneMonitor();
            }
        }

        private static void BuyMobileWorkStation() { }

        private static void RequestTwoMonitors() { }

        private static void BuyLaptop() { }

        private static void RequestOneMonitor(){ }
    }
}
