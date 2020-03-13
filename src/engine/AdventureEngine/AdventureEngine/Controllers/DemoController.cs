using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureEngine.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureEngine.Controllers
{
    [Route("demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public List<IEnumerable> GetAll()
        {
            return Demo.DemoItems;
        }
    }
}
