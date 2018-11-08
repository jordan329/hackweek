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
    public class DetailsController : ControllerBase
    {
        [HttpGet("{placeId}")]
        public ActionResult<string> Get(string placeId)
        {
            var res = DetailsCaller.call(placeId);
            res.Wait();
            return res.Result;
        }
    }
}
