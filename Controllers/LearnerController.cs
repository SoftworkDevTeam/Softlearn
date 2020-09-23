using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoftLearn.ResponseModels;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.RequestModels;
using SoftLearnFrontEnd.ResponseModels;

namespace SoftLearn.Controllers
{
    public class LearnerController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();
        public IActionResult Index()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            GenericResponseModel response = new GenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("Learner/login", model, "");
            response = JsonConvert.DeserializeObject<GenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                var jwtToken = response.Token;
                HttpContext.Session.SetString("Token", jwtToken);

                return RedirectToAction("index", "Learner");

            }
            else if (response.StatusCode == 409)
            {
                return RedirectToAction("ActivateAccount", "Learner");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LearnerRegRequestModel model)
        {
            LearnerRegGenericResponseModel response = new LearnerRegGenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("Learner/signUp", model, "");
            response = JsonConvert.DeserializeObject<LearnerRegGenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                var jwtToken = response.Token;
                string userEmail = response.Data.Email;
                //set the token session 
                HttpContext.Session.SetString("Token", jwtToken);
                HttpContext.Session.SetString("UserEmail", userEmail);

                return RedirectToAction("ActivateAccount", "Learner");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
        }
        [HttpGet]
        public IActionResult ActivateAccount()
        {
            ViewData["UserEmail"] = HttpContext.Session.GetString("UserEmail");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ActivateAccount(AccountActivationRequestModel model)
        {
            ViewData["UserEmail"] = HttpContext.Session.GetString("UserEmail");
            var jwtToken = HttpContext.Session.GetString("Token");
            
            GenericResponseModel response = new GenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPutResponse("Learner/activateAccount", model, jwtToken);
            response = JsonConvert.DeserializeObject<GenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                TempData["alert"] = "alert-success";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> CreateSchool()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            var jwtToken = HttpContext.Session.GetString("Token");
            //TeacherRoles teacherRoles = new TeacherRoles();
            var apiResponse = await httpClientConfig.ApiGetResponse("SchoolType/getAllSchoolType", jwtToken);

            var res = JObject.Parse(apiResponse);
            SchoolSignUpRequestModel request = new SchoolSignUpRequestModel();
            request.SchooltypeList = JsonConvert.DeserializeObject<List<SchoolTypeList>>(res["data"].ToString());

            return View(request);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSchool(SchoolSignUpRequestModel model)
        {
          SchoolSignUpResponseModel response = new SchoolSignUpResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("​School/schoolSignUp", model, "");
            response = JsonConvert.DeserializeObject<SchoolSignUpResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                var jwtToken = response.Token;
               
                //set the token session 
                HttpContext.Session.SetString("Token", jwtToken);
               // HttpContext.Session.SetString("UserEmail", userEmail);

                return RedirectToAction("ActivateSchool", "Learner");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
        }

        [HttpGet]
        public IActionResult ActivateSchool()
        {
          //  ViewData["UserEmail"] = HttpContext.Session.GetString("UserEmail");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ActivateSchool(AccountActivationRequestModel model)
        {
            ViewData["UserEmail"] = HttpContext.Session.GetString("UserEmail");
            var jwtToken = HttpContext.Session.GetString("Token");

            GenericResponseModel response = new GenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPutResponse("School/activateAccount", model, jwtToken);
            response = JsonConvert.DeserializeObject<GenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                TempData["alert"] = "alert-success";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
        }
    }
}
