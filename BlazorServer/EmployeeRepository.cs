using BlazorServer.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer
{
    public class EmployeeRepository : IEmployee
    {
        private readonly HttpClient _httpclient;
        public EmployeeRepository(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public async Task<IEnumerable<People>> GetEmployee()
        {
           
            return await  _httpclient.GetJsonAsync<List<People>>("https://localhost:44352/api/PeopleApi");
           
           
        }
    }
}
