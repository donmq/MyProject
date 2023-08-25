using API.DTO.Personal;
using API.Helper.Attributes;
using API.Helpers.Utilities;

namespace API._Services.Interfaces.Persional
{
    [DependencyInjectionAttribute(ServiceLifetime.Scoped)]
    public interface IEmployeeData
    {
        Task<PaginationUtility<EmployeeDataDto>> GetData(PaginationParam pagination);
    }
}