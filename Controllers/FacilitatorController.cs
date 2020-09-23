using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoftLearn.Models;
using SoftLearn.ResponseModels;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.RequestModels;
using SoftLearnFrontEnd.ResponseModels;

namespace SoftLearn.Controllers
{
    public class FacilitatorController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();

        public IActionResult Index1()
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            return View();
        }

        public IActionResult Dashboard()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            ViewData["UserId"] = HttpContext.Session.GetString("UserId");
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            return View();
        }
        public IActionResult Index()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            ViewData["UserId"] = HttpContext.Session.GetString("UserId");
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            FacLoginGenericResponseModel response = new FacLoginGenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("Facilitator/login", model, "");
            response = JsonConvert.DeserializeObject<FacLoginGenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                var UserId = response.Data.UserId;
                var UserName = response.Data.FirstName + " " + response.Data.LastName;
                
                var jwtToken = response.Token;
                HttpContext.Session.SetString("Token", jwtToken);
                HttpContext.Session.SetString("UserId", UserId);
                HttpContext.Session.SetString("UserName", UserName);

                return RedirectToAction("Dashboard", "Facilitator");
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
        public async Task<IActionResult> Create(FacilitatorRegRequestModel model)
        {
            FacRegGenericResponseModel response = new FacRegGenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("Facilitator/signUp", model, "");
            response = JsonConvert.DeserializeObject<FacRegGenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                var jwtToken = response.Token;
                string userEmail = response.Data.Email;
                //set the token session 
                HttpContext.Session.SetString("Token", jwtToken);
                HttpContext.Session.SetString("UserEmail", userEmail);

                return RedirectToAction("ActivateAccount", "Facilitator");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View(model);
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

            var AccountActivate = new AccountActivationRequestModel
            {
                Email = ViewData["UserEmail"].ToString(),
                Code = model.Code
            };

            GenericResponseModel response = new GenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPutResponse("Facilitator/activateAccount", AccountActivate, jwtToken);
            response = JsonConvert.DeserializeObject<GenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                TempData["alert"] = "alert-success";
                ViewBag.Message = response.StatusMessage;
                return View();
               // return RedirectToAction("index", "Facilitator");
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = response.StatusMessage;
                return View();
            }
        }

        [HttpGet]

        public IActionResult ViewCourse()
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> AddCourse()
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            var jwtToken = HttpContext.Session.GetString("Token");
            ViewData["UserId"] = HttpContext.Session.GetString("UserId");

            CourseCreateRequestModel crs = new CourseCreateRequestModel();
            CourseDropdownRequestModel requestModel = new CourseDropdownRequestModel();

            var apiResponse = await httpClientConfig.ApiGetResponse("CourseType/getAllCourseType", jwtToken);

            var res = JObject.Parse(apiResponse);
            crs.CourseTypes = JsonConvert.DeserializeObject<List<CourseTypes>>(res["data"].ToString());
           // requestModel.CourseTypes = JsonConvert.DeserializeObject<List<CourseTypes>>(res["data"].ToString());

            var apiResponse2 = await httpClientConfig.ApiGetResponse("CourseLevel/getAllCourseLevel", jwtToken);

            var res2 = JObject.Parse(apiResponse2);
            crs.CourseLevel = JsonConvert.DeserializeObject<List<CourseLevel>>(res2["data"].ToString());
           // requestModel.CourseLevel = JsonConvert.DeserializeObject<List<CourseLevel>>(res2["data"].ToString());

            var apiResponse3 = await httpClientConfig.ApiGetResponse("CourseCategory/getAllCourseCategory", jwtToken);

            var res3 = JObject.Parse(apiResponse3);
            crs.CourseCategory = JsonConvert.DeserializeObject<List<CourseCategory>>(res3["data"].ToString());
           // requestModel.CourseCategory = JsonConvert.DeserializeObject<List<CourseCategory>>(res3["data"].ToString());


            // ViewBag["Courselevel"] = request2;

            return View(crs);
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse(CourseCreateRequestModel model)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            var jwtToken = HttpContext.Session.GetString("Token");
            var userId = HttpContext.Session.GetString("UserId");

            //CourseDropdownRequestModel requestModel = new CourseDropdownRequestModel();


            var apiResponse = await httpClientConfig.ApiGetResponse("CourseType/getAllCourseType", jwtToken);

            var res = JObject.Parse(apiResponse);
            model.CourseTypes = JsonConvert.DeserializeObject<List<CourseTypes>>(res["data"].ToString());
            //requestModel.CourseTypes = JsonConvert.DeserializeObject<List<CourseTypes>>(res["data"].ToString());

            var apiResponse2 = await httpClientConfig.ApiGetResponse("CourseLevel/getAllCourseLevel", jwtToken);

            var res2 = JObject.Parse(apiResponse2);
            model.CourseLevel = JsonConvert.DeserializeObject<List<CourseLevel>>(res2["data"].ToString());
           // requestModel.CourseLevel = JsonConvert.DeserializeObject<List<CourseLevel>>(res2["data"].ToString());


            var apiResponse3 = await httpClientConfig.ApiGetResponse("CourseCategory/getAllCourseCategory", jwtToken);

            var res3 = JObject.Parse(apiResponse3);
            model.CourseCategory = JsonConvert.DeserializeObject<List<CourseCategory>>(res3["data"].ToString());
            //requestModel.CourseCategory = JsonConvert.DeserializeObject<List<CourseCategory>>(res3["data"].ToString());

            var newCourse = new CourseCreateRequestModel
            {
                FacilitatorId = new Guid(userId),
                CourseName = model.CourseName,
                CourseDescription = model.CourseDescription,
                CourseCategoryId = model.CourseCategoryId,
                LevelTypeId = model.LevelTypeId,
                AboutCourse = model.AboutCourse,
                CourseImage = model.CourseImage,
                CourseTypeId = model.CourseTypeId,
                DateStart = model.DateStart,
                DateEnd = model.DateEnd,
                CourseAmount = model.CourseAmount
            };

            ViewBag.obj = JsonConvert.SerializeObject(newCourse);
            return View(model);
            //var apiResponsee = await httpClientConfig.ApiPostResponse("Course/createCourse", newCourse, jwtToken);
            //var response = JsonConvert.DeserializeObject<GenericResponseModel>(apiResponsee);

            //if (response.StatusCode == 200)
            //{
            //    TempData["alert"] = "alert-success";
            //    ViewBag.Message = response.StatusMessage;
            //    return View(model);
            //}
            //else
            //{
            //    TempData["alert"] = "alert-danger";
            //    ViewBag.Message = response.StatusMessage;
            //    return View(model);
            //}

        }
    }
}
