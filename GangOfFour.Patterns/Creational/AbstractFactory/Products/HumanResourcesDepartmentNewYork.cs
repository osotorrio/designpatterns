namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class HumanResourcesDepartmentNewYork : IHumanResourcesDepartment
    {
        public void KickOffEmployeeOnboarding(string employee)
        {
            PrintOutPolicyCompanyDocuments(employee);
            ScheduleTeamPresentationMetting();
        }

        private void PrintOutPolicyCompanyDocuments(string employee) { }

        private void ScheduleTeamPresentationMetting() { }
    }
}
