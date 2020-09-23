using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.Models;
using SoftLearnFrontEnd.ResponseModels;
using SoftLearnFrontEnd.RequestModels;
using Newtonsoft.Json.Linq;

namespace SoftLearnFrontEnd.Controllers
{
    public class SuperAdminController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();


        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(SuperAdminRegisterViewModel model)
        {
            //var tuple = new Tuple<SuperAdminRegisterViewModel, SuperAdminCreateResponse>(new SuperAdminRegisterViewModel(), new SuperAdminCreateResponse());

            SuperAdminCreateResponse response = new SuperAdminCreateResponse();
            var apiResponse = await httpClientConfig.ApiPostResponse("SuperAdmin/createSuperAdmin", model, "");
            response = JsonConvert.DeserializeObject<SuperAdminCreateResponse>(apiResponse);

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

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(SuperAdminLoginViewModel model)
        {
            GenericResponseModel response = new GenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("SuperAdmin/superAdminLogin", model, "");
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
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SchoolTypes()
        {
            var jwtToken = HttpContext.Session.GetString("Token");
            SchoolTypes SchoolTypesList = new SchoolTypes();
            var apiResponse = await httpClientConfig.ApiGetResponse("SchoolType/getAllSchoolType", jwtToken);
            SchoolTypesList = JsonConvert.DeserializeObject<SchoolTypes>(apiResponse);

            return View(SchoolTypesList);

        }
        [HttpGet]
        public async Task<IActionResult> CreateTeacher()
        {
            var jwtToken = HttpContext.Session.GetString("Token");
            //TeacherRoles teacherRoles = new TeacherRoles();
            var apiResponse = await httpClientConfig.ApiGetResponse("Teacher/teacherRoles", jwtToken);

            var res = JObject.Parse(apiResponse);
            TeacherCreateRequestModel request = new TeacherCreateRequestModel();
            request.teacherRole = JsonConvert.DeserializeObject<List<TeacherRoles>>(res["data"].ToString());

            return View(request);

        }
        [HttpPost]
        public async Task<IActionResult> CreateTeacher(TeacherCreateRequestModel model)
        {
            TeacherCreateResponseModel response = new TeacherCreateResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("Facilitator/login", model, "");
            response = JsonConvert.DeserializeObject<TeacherCreateResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                TempData["alert"] = "alert-success";
                ViewBag.Message = "Registered successfully.";

                return View(model);
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
    }
}