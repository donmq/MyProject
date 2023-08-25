
using API.DTO.Personal;
using API.Models;
using AutoMapper;


namespace API.Helpers.AutoMapper
{
    public class EfToDtoMappingProfile : Profile
    {
        public EfToDtoMappingProfile()
        {
            //Manage
            CreateMap<EmployeeDataDto, Employee>();
            // CreateMap<Position, PositionManageDto>();
            // CreateMap<PosLang, PosLangManageDto>();
            // CreateMap<Company, CompanyManageDto>();
            // CreateMap<GroupBase, GroupBaseDto>();
            // CreateMap<GroupLang, GroupLangDto>();
            // CreateMap<Holiday, HolidayDto>();
            // CreateMap<Holiday, UserHolidayDto>();
            // CreateMap<Department, DepartmentDto>();
            // CreateMap<Area, AreaDto>();
            // CreateMap<Building, BuildingDto>();
            // CreateMap<DatePickerManager, DatepickerDto>();
            // CreateMap<Employee, EmployeeDto>();
            // CreateMap<HistoryEmp, Dtos.Common.HistoryEmpDto>();
            // CreateMap<HistoryEmp, Dtos.Manage.EmployeeManage.HistoryEmpDto>();
            // CreateMap<LeaveData, Dtos.Manage.EmployeeManage.LeaveDataDto>();
            // CreateMap<Users, UsersDto>();
            // CreateMap<CommentArchive, CommentArchiveDto>();
            // CreateMap<LeaveData, Dtos.Common.LeaveDataDto>();
            // CreateMap<LeaveData, Dtos.Leave.LeaveDataDto>();
            // CreateMap<Part, PartDto>();
            // CreateMap<LeaveData, LeaveDataApproveDto>();
            // CreateMap<ReportData, ReportDataDto>();
            // CreateMap<LeaveData, LeaveDataViewDto>();
            // CreateMap<LeaveData, LeaveDataViewModel>();
            // CreateMap<Users, UserForDetailDto>();
        }
    }
}