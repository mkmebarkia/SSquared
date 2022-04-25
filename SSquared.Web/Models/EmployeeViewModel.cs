using SSquared.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SSquared.Web.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public int? ManagerID { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }

    public class RoleViewModel
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
    }
}
