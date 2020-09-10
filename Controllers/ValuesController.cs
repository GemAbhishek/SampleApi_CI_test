using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi_CI_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly string[] val = new[]
        {
            "value1","value22","value33"
        };


        [HttpGet]
        public string[] getall()
        {
            return val;
        }
    }
}
