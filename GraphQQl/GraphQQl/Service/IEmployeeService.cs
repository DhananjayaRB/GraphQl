using GraphQQl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GraphQQl.Service.EmployeeService;

namespace GraphQQl.Service
{
   public interface IEmployeeService
    {
        Task<Employee> Create(Employee employee);
        Task<bool> Delete(DeleteVM deleteVM);

        IQueryable<Employee> GetAll();

    }
}
