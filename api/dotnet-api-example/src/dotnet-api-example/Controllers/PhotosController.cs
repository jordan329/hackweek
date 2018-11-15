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
    public class PhotosController : ControllerBase
    {
        [HttpGet("{photo}")]
        public ActionResult<string> Get(string photo)
        {
            var res = PhotosCaller.call(photo);
            res.Wait();
            return res.Result;
        }
    }
}
