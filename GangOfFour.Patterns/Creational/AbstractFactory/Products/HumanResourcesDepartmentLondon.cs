namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class HumanResourcesDepartmentLondon : IHumanResourcesDepartment
    {
        public void KickOffEmployeeOnboarding(string employee)
        {
            PrintOutPolicyCompanyDocuments(employee);
            AddEmployeeToCoreValuesAndDecordTraining(employee);
            ScheduleTeamDrinks();
        }

        private void PrintOutPolicyCompanyDocuments(string employee) { }

        private void AddEmployeeToCoreValuesAndDecordTraining(string employee) { }

        private void ScheduleTeamDrinks() { }
    }
}
