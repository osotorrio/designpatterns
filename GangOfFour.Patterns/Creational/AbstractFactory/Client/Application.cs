﻿using GangOfFour.Patterns.Creational.AbstractFactory.Factories;
using GangOfFour.Patterns.Creational.AbstractFactory.Stuff;
using System.Collections.Generic;
using Xunit;

namespace GangOfFour.Patterns.Creational.AbstractFactory.Client
{
    public class Application
    {
        [Theory]
        [MemberData(nameof(InjectDependencies))]
        public void ExampleAbstractFactory(IAbstractOffice office, string employee, JobTitles jobTitle)
        {
            var hrDepartment = office.CreateHumanResourcesDeparment();
            var securityDepartment = office.CreateSecurityDepartment();
            var purchasingDepartment = office.CreatePurchasingDepartment();

            hrDepartment.KickOffEmployeeOnboarding(employee);
            securityDepartment.RequestOfficeSecurityCredentials(employee, jobTitle);
            purchasingDepartment.RequestLaptopSetup(jobTitle);
        }

        public static IEnumerable<object[]> InjectDependencies()
        {
            return new List<object[]>
            {
                new object[] { new LondonOffice(), "Richard Wood", JobTitles.Developer },
                new object[] { new NewYorkOffice(), "Rachel Smith", JobTitles.Director }
            };
        }
    }
}
