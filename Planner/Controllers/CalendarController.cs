using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
        
    }

}
