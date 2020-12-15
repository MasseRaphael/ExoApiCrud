using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiMicromania.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicromaniaController : Controller
    {
        public JsonResult Index()
        {
            List<int> list = new List<int>
            {
                1,2,3,4,5
            };

            return (Json(list));
        }
    }
}
