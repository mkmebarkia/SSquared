using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Core.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
