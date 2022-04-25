using SSquared.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Core.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllManagers();
        IEnumerable<Employee> GetAllEmployeeByManager(int managerId);
        IEnumerable<Role> GetAllRoles();
        Role GetRoleById(int roleId);
        void AddEmployee (Employee employee, string[]? employeeRoles);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetAllEmployeeById(int employeeId);
       
    }
}
