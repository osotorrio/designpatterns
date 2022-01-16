namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class HumanResourcesDepartmentNewYork : IHumanResourcesDepartment
    {
        public void KickOffEmployeeOnboarding(string employee)
        {
            PrintOutPolicyCompanyDocuments(employee);
            ScheduleTeamPresentationMetting();
        }

        private static void PrintOutPolicyCompanyDocuments(string employee) { }

        private static void ScheduleTeamPresentationMetting() { }
    }
}
