using API.DTO.Personal;

using API.Models;
using AutoMapper;

namespace API.Helpers.AutoMapper
{
    public class DtoToEfMappingProfile : Profile
    {
        public DtoToEfMappingProfile()
        {
            //Manage
            CreateMap<EmployeeDataDto, Employee>();
            // CreateMap<PosLangManageDto, PosLang>();
            // CreateMap<CompanyManageDto, Company>();
            // CreateMap<GroupBaseDto, GroupBase>();
            // CreateMap<GroupLangDto, GroupLang>();
            // CreateMap<HolidayDto, Holiday>();
            // CreateMap<UserHolidayDto, Holiday>();
            // CreateMap<DepartmentDto, Department>();
            // CreateMap<AreaDto, Area>();
            // CreateMap<BuildingDto, Building>();
            // CreateMap<DatepickerDto, DatePickerManager>();
            // CreateMap<EmployeeDto, Employee>();
            // CreateMap<Dtos.Common.HistoryEmpDto, HistoryEmp>();
            // CreateMap<Dtos.Manage.EmployeeManage.LeaveDataDto, LeaveData>();
            // CreateMap<UsersDto, Users>();
            // CreateMap<CommentArchiveDto, CommentArchive>();
            // CreateMap<Dtos.Manage.EmployeeManage.HistoryEmpDto, HistoryEmp>();
            // CreateMap<Dtos.Common.LeaveDataDto, LeaveData>();
            // CreateMap<Dtos.Leave.LeaveDataDto, LeaveData>();
            // CreateMap<PartDto, Part>();
            // CreateMap<LeaveDataApproveDto, LeaveData>();
            // CreateMap<ReportDataDto, ReportData>();
            // CreateMap<LeaveDataDTO, LeaveData>();
            // CreateMap<ReportDataDto, ReportData>();
            // CreateMap<LeaveDataViewDto, LeaveData>();
            // CreateMap<UserForDetailDto, Users>();
        }
    }
}