namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class HumanResourcesDepartmentNewYork : IHumanResourcesDepartment
    {
        /// <summary>
        /// HR department in New York has a specific way of handling the on boarding process for a newcomer which is different from any other office.
        /// </summary>
        public void KickOffEmployeeOnboarding(string employee)
        {
            PrintOutPolicyCompanyDocuments(employee);
            ScheduleTeamDrinks();
        }

        private void PrintOutPolicyCompanyDocuments(string employee) { }

        private void ScheduleTeamDrinks() { }
    }
}
