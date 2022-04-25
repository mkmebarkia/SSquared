using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Core.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Employee Manager { get; set; }

        public int? ManagerID { get; set; }

        public List<Employee> Reports { get; set; }

        public List<Role> Roles { get; set; }
    }
}
