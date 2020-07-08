using BlazorServer.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override Task OnInitializedAsync()
        {
            GetEmployee();
            return base.OnInitializedAsync();
        }
        private void GetEmployee()
        {
            var employee1 = new Employee
            {
                id = 1,
                Name = "Tom",
                Designation = "TechLead"
            };
            var employee2 = new Employee
            {
                id = 2,
                Name = "Harry",
                Designation = "Software Engineer"
            };
            Employees = new List<Employee> { employee1, employee2 };
        }
    }
}
