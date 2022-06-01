using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Controllers
{
    public class PlanController : Controller
    {
        public IActionResult Plan()
        {
            return View();
        }
    }
}
