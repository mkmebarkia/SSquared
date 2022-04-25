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
        IEnumerable<Employee> GetAllEmployeeByManager(int EmployeeID);

        IEnumerable<Employee> GetAllManager();
        
    }
}
