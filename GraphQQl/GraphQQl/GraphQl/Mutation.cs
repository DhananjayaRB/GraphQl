using GraphQQl.Model;
using GraphQQl.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GraphQQl.Service.EmployeeService;

namespace GraphQQl.GraphQl
{
    public class Mutation
    {
        private readonly IEmployeeService _employeeService;

        public Mutation(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<Employee> Create(Employee employee) => await _employeeService.Create(employee);
        public async Task<bool> Delete(DeleteVM deleteVM) => await _employeeService.Delete(deleteVM);



    }
}
