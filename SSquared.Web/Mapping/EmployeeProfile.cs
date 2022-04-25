using AutoMapper;
using SSquared.Core.Models;
using SSquared.Web.Models;

namespace SSquared.Web.Mapping
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            // Domain to ViewModel
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<Role, RoleViewModel>();

            // ViewModel Domain
            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<RoleViewModel, Role>();
        }

    }
}
