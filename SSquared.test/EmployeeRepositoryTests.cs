using Moq;
using SSquared.Core;
using SSquared.Core.Models;
using SSquared.Core.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SSquared.test
{
    /// <summary>
    /// some unit tests (not exhaustive) just for the demo
    /// </summary>
    public class EmployeeRepositoryTests
    {
        private readonly Mock<IUnitOfWork> service;
        public EmployeeRepositoryTests()
        {
            service = new Mock<IUnitOfWork>();
        }

        [Fact]
       
        public void GetEmployeeByManager_ListOfEmployeeo()
        {
            //arrange
            var employee = GetSampleEmployee();
            service.Setup(x => x.Employees.GetAllEmployeeByManager(1))
                .Returns(GetSampleEmployee);

            var employeeService = new EmployeeService(service.Object);
          
            //act
            var actual = employeeService.GetAllEmployeeByManager(1);
         
            //assert         
            Assert.Equal(GetSampleEmployee().Count(), actual.Count());
        }

        [Fact]

        public void GetEmployeeById_ListOfEmployeeo()
        {
            //arrange
            var employees = GetSampleEmployee();
            var first = employees[0];
            service.Setup(x => x.Employees.GetEmployeeWithRoles(1))
                .Returns(first);

            var employeeService = new EmployeeService(service.Object);

            //act
            var actual = employeeService.GetEmployeeById(1);

            //assert         
            Assert.Equal(first,actual);
         
        }

        private List<Employee> GetSampleEmployee()
        {
            var Director = new Role { RoleID = 1, Name = "Director" };
            var Support = new Role { RoleID = 2, Name = "Support" };
            var IT = new Role { RoleID = 3, Name = "IT" };
            var Accounting = new Role { RoleID = 4, Name = "Accounting" };
            var Analyst = new Role { RoleID = 5, Name = "Analyst" };
            var Sales = new Role { RoleID = 6, Name = "Sales" };


            List<Employee> output = new List<Employee>
        {
              new Employee
            {
                EmployeeID = 1,
                FirstName = "Jeffrey",
                LastName = "Wells",
                  Roles = new List<Role>() { Director }
            },

             new Employee
            {
                EmployeeID = 2,
                FirstName = "Victor",
                LastName = "Atkins",
                    Roles = new List<Role>() { Director },
                    ManagerID = 1
            },

             new Employee
            {
                EmployeeID = 3,
                FirstName = "Kelli",
                LastName = "Hamilton",
                    Roles = new List<Role>() { Director },
                    ManagerID = 1
            },

            new Employee
            {
                EmployeeID = 4,
                FirstName = "Adam",
                LastName = "Braun",
                   Roles = new List<Role>() { IT,Support },
                   ManagerID = 2
            },
             new Employee
            {
                EmployeeID = 5,
                FirstName = "Lois",
                LastName = "Martinez",
                   Roles = new List<Role>() { Support },
                   ManagerID = 3
            },
             new Employee
            {
                EmployeeID = 6,
                FirstName = "Brian",
                LastName = "Cruz",
                   Roles = new List<Role>() { Accounting },
                   ManagerID = 2
            },
             new Employee
            {
                EmployeeID = 7,
                FirstName = "Michael",
                LastName = "Lind",
                  Roles = new List<Role>() { Analyst },
                  ManagerID = 3
            },
             new Employee
            {
                EmployeeID = 8,
                FirstName = "Kristen",
                LastName = "Floyd",
                   Roles = new List<Role>() { Analyst,Sales },
                   ManagerID = 2,
            },
             new Employee
            {
                EmployeeID = 9,
                FirstName = "Eric",
                LastName = "Bay",
                   Roles = new List<Role>() { IT,Sales },
                   ManagerID = 3
            },
             new Employee
            {
                EmployeeID = 10,
                FirstName = "Brandon",
                LastName = "Young",
                   Roles = new List<Role>() { Accounting },
                  ManagerID = 3
            },
        };
            return output;
        }

    }
}
