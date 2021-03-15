using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAspNetCore5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
