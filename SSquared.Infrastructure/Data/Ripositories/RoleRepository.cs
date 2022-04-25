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
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(SSquaredDbContext context) : base(context)
        {
        }

        private SSquaredDbContext SSquaredDbContext
        {
            get { return _context as SSquaredDbContext; }
        }

        public Role GetByIdAsNoTracking(int id)
        {
            return _context.Roles
                           .AsNoTracking()
                           .FirstOrDefault(x => x.RoleID == id);
        }
  
    }
}
