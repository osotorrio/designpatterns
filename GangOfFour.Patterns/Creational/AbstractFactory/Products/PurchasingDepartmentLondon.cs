using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class PurchasingDepartmentLondon : IPurchasingDepartment
    {
        public void RequestLaptopSetup(JobTitles jobTitle)
        {
            if (JobTitles.Developer == jobTitle)
            {
                BuyHighSpeedLaptop();
                BuyBigCurvedScreen();
            }

            if (JobTitles.Director == jobTitle)
            {
                BuyDesktopComputer();
                BuySmallScreen();
            }
        }

        private static void BuySmallScreen() { }

        private static void BuyDesktopComputer() { }

        private static void BuyBigCurvedScreen() { }

        private static void BuyHighSpeedLaptop() { }
    }
}
