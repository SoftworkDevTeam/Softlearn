using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SoftLearn.Controllers
{
    public class CourseController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
