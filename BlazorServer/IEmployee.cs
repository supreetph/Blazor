using BlazorServer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer
{
    public interface IEmployee
    {
        public Task<IEnumerable<People>> GetEmployee();
    }
}
