using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API._Services.Interfaces.Persional;
using Microsoft.AspNetCore.Mvc;
using API.Helpers.Utilities;

namespace API.Controllers.Persional
{
    public class C_Employee : ApiController
    {
        private readonly IEmployeeData _service;
        public C_Employee(IEmployeeData service)
        {
            _service = service;
        }

        [HttpGet("GetData")]
        public async Task<IActionResult> GetData([FromQuery] PaginationParam pagination)
        {
            var data = await _service.GetData(pagination);
            return Ok(data);
        }
    }
}