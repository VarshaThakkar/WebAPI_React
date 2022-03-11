using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI_React.Models;

namespace WebAPI_React.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAll()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee{ Id=101,Name="varsha",Salary=10000},
                new Employee{ Id=102,Name="Krishav",Salary=20000},
                new Employee{ Id=103,Name="Mahesh",Salary=30000}
            };
            return empList;
        }
    }
}
