using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.Models;
using SoftLearnFrontEnd.RequestModels;
using SoftLearnFrontEnd.ResponseModels;


namespace SoftLearnFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> SchoolTypes()
        {
            SchoolTypes SchoolTypesList = new SchoolTypes();
            var apiResponse = await httpClientConfig.ApiGetResponse("SchoolType/getAllSchoolType", "");
            SchoolTypesList = JsonConvert.DeserializeObject<SchoolTypes>(apiResponse);

            return View(SchoolTypesList);
           
        }

        //------------ LOGIN ----------------------------------
        [HttpPost]
        public IActionResult SchoolAdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FacilitatorLogin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LearnerLogin()
        {
            return View();
        }
        
        [HttpPost]

        [HttpPost]
        public IActionResult StudentLogin()
        {
            return View();
        }


        //---------------- SIGNUP --------------------------------

        public IActionResult SchoolSignUp()
        {
            return View();
        }

        public IActionResult FacilitatorSignUp()
        {
            return View();
        }

        public IActionResult LearnerSignUp()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
