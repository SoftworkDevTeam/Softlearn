using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewSoftlearn.Entities;
using NewSoftlearn.ResponseModels;
using Newtonsoft.Json;
using SoftLearn.ResponseModels;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.Models;
using SoftLearnFrontEnd.RequestModels;
using SoftLearnFrontEnd.ResponseModels;


namespace SoftLearnFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();
        public async Task<IActionResult> Index()
        {
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
                return RedirectToAction("index", "home");
            }

            return View();
        }
        public async Task<IActionResult> CoursesByCategory(long categoryId, long pageNumber, long pageSize)
        {

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

        [HttpGet]
        public async Task<IActionResult> CoursePreview(long courseid)
        {
            var jwtToken = HttpContext.Session.GetString("Token");
            var apiResponse = await httpClientConfig.GetRestResponse("Course/courseById?courseid=" + courseid + "", "");
            var result = JsonConvert.DeserializeObject<CoursesGenericResponseModel>(apiResponse);
            ViewBag.CourseInfo = result.Data;

            var apiResponse1 = await httpClientConfig.GetRestResponse("CourseTopics/allCourseTopicsByCourseId?courseId=" + courseid, jwtToken);

            var result1 = JsonConvert.DeserializeObject<CourseTopicGenericReponseModel>(apiResponse1);
           
            if (result1.StatusCode == 200)
            {
                ViewBag.CourseTopicInfo = result1.Data;
            }
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


        //-----------------------------LOGOUT--------------------
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("index", "home");
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
