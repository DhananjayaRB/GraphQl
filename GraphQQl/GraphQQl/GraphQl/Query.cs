using GraphQQl.Model;
using GraphQQl.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQQl.GraphQl
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;

        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IQueryable<Employee> Employee => _employeeService.GetAll();
    }
}
