using System;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Products
{
    public class HumanResourcesDepartmentLondon : IHumanResourcesDepartment
    {
        /// <summary>
        /// HR department in London has a specific way of handling the on boarding process for a newcomer which is different from any other office.
        /// </summary>
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
