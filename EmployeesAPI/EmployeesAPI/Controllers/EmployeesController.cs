using EmployeesAPI.Contract;
using EmployeesAPI.Core;
using EmployeesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeesAPI.Controllers
{
    [RoutePrefix("api")]
    public class EmployeesController : ApiController
    {
        IEmployee employeeService = new EmployeeService();

        [Route("GetEmployees/{id}")]
        [HttpGet]
        public IHttpActionResult GetEmployees(long id)
        {
            return Ok(employeeService.GetEmployees(id));
        }

        [Route("SaveEmployee")]
        public IHttpActionResult SaveEmployee(EmployeeRequest employeeRequest)
        {
            return Ok(employeeService.SaveEmployee(employeeRequest));
        }
    }
}
