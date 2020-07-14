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
        [Inject]
        public IEmployee employeeService { get; set; }
        public List<People> Employees;
       
    
       

      
        protected override async Task OnInitializedAsync()
        {

            Employees = new List<People>();
            Employees = (await employeeService.GetEmployee()).ToList();
            // GetEmployee();
            
        }
        
    }
}
