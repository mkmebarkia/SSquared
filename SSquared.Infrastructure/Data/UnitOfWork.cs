using SSquared.Core;
using SSquared.Core.Repositories;
using SSquared.Infrastructure.Data.Ripositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SSquaredDbContext _context;
        public UnitOfWork(SSquaredDbContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
            Roles = new RoleRepository(_context);
        }
        public IEmployeeRepository Employees { get; private set; }
        public IRoleRepository Roles { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
