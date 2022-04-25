using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSquared.Core.Models;
using SSquared.Core.Services.Interfaces;
using SSquared.Web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SSquared.Web.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }


        // GET: api/<EmployeesController>
        [HttpGet("all")]
        public IEnumerable<EmployeeViewModel> GetAllEmployees()
        {
            var listEmployees = _employeeService.GetAllEmployees();
            var employeeViewModels = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(listEmployees);
            return employeeViewModels;
        }

        [HttpGet("allmanagers")]
        public IEnumerable<EmployeeViewModel> GetAllManagers()
        {
            var listManagers = _employeeService.GetAllManagers();
            var managerViewModels = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(listManagers);
            return managerViewModels;
        }

        [HttpGet("allbymanager/{id}")]
        public IEnumerable<EmployeeViewModel> GetAllEmployeesByManager(int id)
        {
            var listEmployees = _employeeService.GetAllEmployeeByManager(id);
            var employeeViewModels = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(listEmployees);
            return employeeViewModels;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public EmployeeViewModel Get(int id)
        {
            var employees = _employeeService.GetAllEmployeeById(id);
            var employeeViewModel = _mapper.Map<Employee, EmployeeViewModel>(employees);
            return employeeViewModel;
        }


    }
}
