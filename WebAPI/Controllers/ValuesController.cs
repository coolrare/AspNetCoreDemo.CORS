using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "GET", "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<string>> Post()
        {
            return new string[] { "POST", "value1", "value2" };
        }

        // PUT api/values
        [HttpPut]
        public ActionResult<IEnumerable<string>> Put()
        {
            return new string[] { "PUT", "value1", "value2" };
        }

        // DELETE api/values
        [HttpDelete]
        public ActionResult<IEnumerable<string>> Delete()
        {
            return new string[] { "DELETE", "value1", "value2" };
        }
    }
}
