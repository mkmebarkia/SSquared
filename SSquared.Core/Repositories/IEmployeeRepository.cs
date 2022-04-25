using SSquared.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {    
        IEnumerable<Employee> GetAllEmployeeByManager(int employeeID);
        IEnumerable<Employee> GetAllManagers();
        IEnumerable<Employee> GetAllEmployeesWithRoles();
        Employee GetEmployeeWithRoles(int employeeId);
    }
}
