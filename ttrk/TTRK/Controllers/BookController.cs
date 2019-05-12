using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TTRK.Controllers
{
    public class BookController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return Content("Hello from lazzy world");
        }
    }
}