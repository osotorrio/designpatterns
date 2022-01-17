namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class HumanResourcesDepartmentLondon : IHumanResourcesDepartment
    {
        public void KickOffEmployeeOnboarding(string employee)
        {
            PrintOutPolicyCompanyDocuments(employee);
            AddEmployeeToCoreValuesAndDecordTraining(employee);
            ScheduleTeamDrinks();
        }

        private static void PrintOutPolicyCompanyDocuments(string employee) { }

        private static void AddEmployeeToCoreValuesAndDecordTraining(string employee) { }

        private static void ScheduleTeamDrinks() { }
    }
}
