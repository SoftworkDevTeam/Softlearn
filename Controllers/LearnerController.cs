using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewSoftlearn.Entities;
using NewSoftlearn.ResponseModels;
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
            ViewData["UserEmail"] = HttpContext.Session.GetString("UserEmail");
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            return View();
        }
        public IActionResult Dashboard()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            ViewData["UserId"] = HttpContext.Session.GetString("UserId");
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            LearnerRegGenericResponseModel response = new LearnerRegGenericResponseModel();
            var apiResponse = await httpClientConfig.ApiPostResponse("Learner/login", model, "");
            response = JsonConvert.DeserializeObject<LearnerRegGenericResponseModel>(apiResponse);

            if (response.StatusCode == 200)
            {
                var jwtToken = response.Token;
                var UserName = response.Data.FirstName + " " + response.Data.LastName;

                HttpContext.Session.SetString("UserName", UserName);
                HttpContext.Session.SetString("Token", jwtToken);

                return RedirectToAction("Dashboard", "Learner");

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
        public async Task<IActionResult> Create()
        {
            //CourseLevel
            var apiResponse = await httpClientConfig.GetRestResponse("CourseLevel/getAllCourseLevel", "");
            var courseLevel = JsonConvert.DeserializeObject<CourseLevelTypes>(apiResponse);

            courseLevel.Data.Insert(0, new CourseLevelTypesData { id = 0, levelTypeName = "Select Course Level" });
            ViewBag.CourseLevelList = courseLevel.Data;

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

        //---------------------------------------Courses by Category-------------------------------------
        public async Task<IActionResult> CourseCategory()
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            long pageNumberFromQuery = Convert.ToInt64(HttpContext.Request.Query["pageNumber"]);
            long pageSizeFromQuery = Convert.ToInt64(HttpContext.Request.Query["pageSize"]);

            ViewBag.pageNumber = 0;
            ViewBag.pageSize = 0;

            //long pageNumber = 0;
            //long pageSize = 0;

            if (pageNumberFromQuery > 0 && pageSizeFromQuery > 0)
            {
                if (pageNumberFromQuery == 0)
                {
                    ViewBag.pageNumber = 1;
                    ViewBag.pageSize = pageSizeFromQuery;
                }
                else
                {
                    ViewBag.pageNumber = pageNumberFromQuery;
                    ViewBag.pageSize = pageSizeFromQuery;
                }

            }
            else
            {
                ViewBag.pageNumber = 1;
                ViewBag.pageSize = 6;
            }


            var apiResponse = await httpClientConfig.GetRestResponse("CourseCategory/getAllCourseCategoryPagination?pageNumber=" + ViewBag.pageNumber + "&pageSize=" + ViewBag.pageSize + "", "");
            var result = JsonConvert.DeserializeObject<CourseCategory>(apiResponse);

            if (result.Data != null)
            {
                ViewBag.CourseCategoryList = result.Data;
            }
            else
            {
               // return RedirectToAction("index", "home");
            }

            return View();
        }

        public async Task<IActionResult> CoursesByCategory(long categoryId, long pageNumber, long pageSize)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            //--------------Category By ID ------------------------------
            ViewBag.courseCategoryId = Convert.ToInt64(categoryId);

            var apiResponse = await httpClientConfig.GetRestResponse("CourseCategory/courseCategoryById?courseCategoryId=" + ViewBag.courseCategoryId + "", "");
            var result = JsonConvert.DeserializeObject<SingleCourseCategory>(apiResponse);
            ViewBag.CourseCategory = result.Data;


            //------------Courses By Category With Pagination----------------------------------------


            long pageNumberFromQuery = Convert.ToInt64(HttpContext.Request.Query["pageNumber"]);
            long pageSizeFromQuery = Convert.ToInt64(HttpContext.Request.Query["pageSize"]);

            ViewBag.pageNumber = 0;
            ViewBag.pageSize = 0;

            //long pageNumber = 0;
            //long pageSize = 0;

            if (pageNumberFromQuery > 0 && pageSizeFromQuery > 0)
            {
                if (pageNumberFromQuery == 0)
                {
                    ViewBag.pageNumber = 1;
                    ViewBag.pageSize = pageSizeFromQuery;
                }
                else
                {
                    ViewBag.pageNumber = pageNumberFromQuery;
                    ViewBag.pageSize = pageSizeFromQuery;
                }

            }
            else
            {
                ViewBag.pageNumber = 1;
                ViewBag.pageSize = 4;
            }


            var apiResponse1 = await httpClientConfig.GetRestResponse("Course/coursesPaginationByCategoryId?categoryId=" + ViewBag.courseCategoryId + "&pageNumber=" + ViewBag.pageNumber + "&pageSize=" + ViewBag.pageSize + "", "");
            var result1 = JsonConvert.DeserializeObject<CourseDataResponse>(apiResponse1);
            ViewBag.CoursesList = result1.Data;


            return View();
        }

        public async Task<IActionResult> NewView()
        {
            var jwtToken = HttpContext.Session.GetString("Token");
            long pageNumberFromQuery = Convert.ToInt64(HttpContext.Request.Query["pageNumber"]);
            long pageSizeFromQuery = Convert.ToInt64(HttpContext.Request.Query["pageSize"]);

            ViewBag.pageNumber = 0;
            ViewBag.pageSize = 0;

            //long pageNumber = 0;
            //long pageSize = 0;

            if (pageNumberFromQuery > 0 && pageSizeFromQuery > 0)
            {
                if (pageNumberFromQuery == 0)
                {
                    ViewBag.pageNumber = 1;
                    ViewBag.pageSize = pageSizeFromQuery;
                }
                else
                {
                    ViewBag.pageNumber = pageNumberFromQuery;
                    ViewBag.pageSize = pageSizeFromQuery;
                }

            }
            else
            {
                ViewBag.pageNumber = 1;
                ViewBag.pageSize = 6;
            }


            var apiResponse = await httpClientConfig.GetRestResponse("CourseCategory/getAllCourseCategoryPagination?pageNumber=" + ViewBag.pageNumber + "&pageSize=" + ViewBag.pageSize + "", "");
            var result = JsonConvert.DeserializeObject<CourseCategory>(apiResponse);

            if (result.Data != null)
            {
                ViewBag.CourseCategoryList = result.Data;
            }
            else
            {
               // return RedirectToAction("index", "home");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CoursePreview(long courseid)
        {
            var jwtToken = HttpContext.Session.GetString("Token");
            var apiResponse = await httpClientConfig.GetRestResponse("Course/courseById?courseid=" + courseid + "", "");
            var result = JsonConvert.DeserializeObject<CoursesGenericResponseModel>(apiResponse);
            ViewBag.CourseInfo = result.Data;

            var apiResponse1 = await httpClientConfig.GetRestResponse("CourseTopics/allCourseTopicsByCourseId?courseId=" + courseid, jwtToken);

            var result1 = JsonConvert.DeserializeObject<CourseTopics>(apiResponse1);
            ViewBag.CourseTopicInfo = result1.Data;
            
            return View();
        }


    }
}
