using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API._Repositories;
using API._Services.Interfaces.Persional;
using API.DTO.Personal;
using Microsoft.EntityFrameworkCore;
using API.Helpers.Utilities;
using API.Models;

namespace API._Services.Services.Persional
{
    public class EmployeeData : IEmployeeData
    {
        private readonly IRepositoryAccessor _repo;
        public EmployeeData(IRepositoryAccessor repo)
        {
            _repo = repo;
        }
        public async Task<PaginationUtility<EmployeeDataDto>> GetData(PaginationParam pagination)
        {
            List<Employee> employees = await _repo.Employee.FindAll().ToListAsync();
            List<EmployeeDataDto> data = employees.Select(e => new EmployeeDataDto
            {
                EmpID = e.EmpID,
                EmpName = e.EmpName ?? "",
                EmpNumber = e.EmpNumber ?? "",
                DateIn = e.DateIn ?? null,
                PositionID = e.PositionID ?? null,
                Descript = e.Descript ?? "",
                GBID = e.GBID ?? null,
                Visible = e.Visible ?? null,
                PartID = e.PartID ?? null,
            }).ToList();
            // _mapper.Map<LeaveDataViewModel>(leaveData);
            return PaginationUtility<EmployeeDataDto>.Create(data, pagination.PageNumber, pagination.PageSize);
        }
    }
}