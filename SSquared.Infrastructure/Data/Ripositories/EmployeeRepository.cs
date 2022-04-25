using Microsoft.EntityFrameworkCore;
using SSquared.Core.Models;
using SSquared.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Infrastructure.Data.Ripositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(SSquaredDbContext context) : base(context)
        {
        }

        public IEnumerable<Employee> GetAllEmployeeByManager(int managerId)
        {
            var employee = SSquaredDbContext.Employees
                .Include("Reports.Roles")
                .AsNoTracking()
                .FirstOrDefault(e => e.EmployeeID == managerId);

            return employee?.Reports ?? GetAllEmployeeWithRoles();
        }

        private IEnumerable<Employee> GetAllEmployeeWithRoles()
        {
            var employees = SSquaredDbContext.Employees
                                    .AsNoTracking()
                                    .Include("Roles");
            return employees;

        }

        public IEnumerable<Employee> GetAllManager()
        {
    
            return SSquaredDbContext.Employees
                                    .FromSqlRaw(@"
                                        select * from Employees 
                                        where EmployeeID IN (select ManagerID from Employees)")
                                    .AsNoTracking()
                                    .ToList();
        }
        
        private SSquaredDbContext SSquaredDbContext
        {
            get { return _context as SSquaredDbContext; }
        }
        
    }
}
