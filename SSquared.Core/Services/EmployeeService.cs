using SSquared.Core.Models;
using SSquared.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Employee> GetAllEmployeeByManager(int managerId)
        {
            var allEmployeeByManager = _unitOfWork.Employees.GetAllEmployeeByManager(managerId);

            return allEmployeeByManager;
        }

        public IEnumerable<Employee> GetAllManagers()
        {
            var allManager = _unitOfWork.Employees.GetAllManager();

            return allManager;
        }

        public IEnumerable<Role> GetAllRoles()
        {
            var roles = _unitOfWork.Roles.GetAll();

            return roles;
        }

        public Role GetRoleById(int roleId)
        {
            var role = _unitOfWork.Roles.GetByIdAsNoTracking(roleId);

            return role;
        }

        public void AddEmployee(Employee employee, string[]? employeeRoles)
        {
            if (employeeRoles != null)
            {
                foreach (var roleId in employeeRoles)
                {
                    var role = _unitOfWork.Roles.Find(x => x.RoleID == Convert.ToInt32(roleId)).FirstOrDefault();
                    if (role != null) employee.Roles.Add(role);
                }
            }
            
            _unitOfWork.Employees.Add(employee);
            _unitOfWork.Complete();
        }
    }
}