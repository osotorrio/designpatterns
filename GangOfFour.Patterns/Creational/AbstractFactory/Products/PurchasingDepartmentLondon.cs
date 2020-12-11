using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Purchasing department in London has a specific way of handling a laptop request which is different from any other office.
    /// </summary>
    public class PurchasingDepartmentLondon : IPurchasingDepartment
    {
        public void RequestDeskSetup(JobTitles jobTitle)
        {
            if (JobTitles.Developer == jobTitle)
            {
                PurchaseHighSpeedLaptop();
                PurchaseBigCurvedScreen();
            }

            if (JobTitles.Director == jobTitle)
            {
                PurchaseDesktopComputer();
                PurchaseSmallScreen();
            }
        }

        private static void PurchaseSmallScreen() { }

        private static void PurchaseDesktopComputer() { }

        private static void PurchaseBigCurvedScreen() { }

        private static void PurchaseHighSpeedLaptop() { }
    }
}
