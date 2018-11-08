using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gplaces_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class PlacesController : ControllerBase
    {
        [HttpGet("{locationQuery}")]
        public ActionResult<string> Get(string locationQuery)
        {
            var res = PlacesCaller.call("pizza%20"+locationQuery);
            res.Wait();
            return res.Result;
        }
    }
}
