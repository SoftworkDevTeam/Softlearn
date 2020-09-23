using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SoftLearn.Models;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.RequestModels;
using SoftLearnFrontEnd.ResponseModels;

namespace SoftLearn.Controllers
{
    public class SchoolController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SchoolSignUpRequestModel model)
        {
            SchoolSignUpResponseModel response = new SchoolSignUpResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("​School​/schoolSignUp", model, "");
            response = JsonConvert.DeserializeObject<SchoolSignUpResponseModel>(apiResponse);
            if (response.StatusCode == 200)
            {
                TempData["alert"] = "alert-success";
                ViewBag.Message = "Registered successfully.";
                // return RedirectToAction("index", "superAdmin");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult SchoolAdminLogin()
        {
            return View();
        }

        public async Task<IActionResult> SchoolAdminLogin(SchoolAdminLoginViewModel model)
        {
            GenericResponseModel response = new GenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("school/SchoolAdminLogin", model, "");
            response = JsonConvert.DeserializeObject<GenericResponseModel>(apiResponse);
            if (response.StatusCode == 200)
            {
                var jwtToken = response.Token;
                
                //set the token session 
                HttpContext.Session.SetString("Token", jwtToken);

                return RedirectToAction("index", "superAdmin");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
            }
            return View();
        }

     


    }
}
