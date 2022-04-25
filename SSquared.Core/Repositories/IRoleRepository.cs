using SSquared.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Core.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetByIdAsNoTracking(int id);
    }
}
