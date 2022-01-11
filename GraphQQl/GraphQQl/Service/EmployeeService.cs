using GraphQQl.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQQl.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbcontext;

        public EmployeeService(DatabaseContext databaseContext)
        {
            _dbcontext = databaseContext;
        }

      public async Task<Employee> Create(Employee employee)
        {
            var data = new Employee
              { 
               Name=employee.Name,
               Id=employee.Id,
               Designation=employee.Designation
              };
            await _dbcontext.Employees.AddAsync(data);
            await _dbcontext.SaveChangesAsync();
            return data;
        }

        public async Task<bool> Delete(DeleteVM deleteVM)
        {
            var employee = await _dbcontext.Employees.FirstOrDefaultAsync(x=>x.Id==deleteVM.Id);
            if(employee is not null)
            {
                _dbcontext.Employees.Remove(employee);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        IQueryable<Employee> IEmployeeService.GetAll()
        {
            return _dbcontext.Employees.AsQueryable();
        }

        public class DeleteVM
        {
            public int Id { get; set; }
        }

    }
}
