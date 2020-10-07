using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewSoftlearn.Entities;
using NewSoftlearn.InterfaceRepositories;
using NewSoftlearn.Models;
using NewSoftlearn.ResponseModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
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
        private IHostingEnvironment _hostingEnvironment;
        private readonly ICloudinaryRepo _cloudinary;
        private static readonly int maximumFileSize = 16777216; //16MB

        public FacilitatorController(IHostingEnvironment environment, ICloudinaryRepo cloudinary)
        {
            _hostingEnvironment = environment;
            _cloudinary = cloudinary;
        }
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


        //--------------------------------------------------COURSES ACTION BY FACILITATOR--------------------------------------------------

        [HttpGet]
        public async Task<IActionResult> ViewCourse()
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            var jwtToken = HttpContext.Session.GetString("Token");
            var UserId = HttpContext.Session.GetString("UserId");

            CoursesbyFacilitatorResponseModel response = new CoursesbyFacilitatorResponseModel();
            var apiResponse = await httpClientConfig.GetRestResponse("Course/allCourseByFacilitatorId?facilitatorId=" + UserId,  jwtToken);
            response = JsonConvert.DeserializeObject<CoursesbyFacilitatorResponseModel>(apiResponse);

            ViewBag.Courses = response.Data;
            return View();
        }

        [HttpGet]
        public IActionResult EditCourse()
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

            //CourseType
            var apiResponse = await httpClientConfig.GetRestResponse("CourseType/getAllCourseType", jwtToken);
            var courseTypes = JsonConvert.DeserializeObject<CourseType>(apiResponse);

            //CourseCategory
            var apiResponse2 = await httpClientConfig.GetRestResponse("CourseCategory/getAllCourseCategory", jwtToken);
            var courseCategory = JsonConvert.DeserializeObject<CourseCategory>(apiResponse2);

            //CourseLevel
            var apiResponse3 = await httpClientConfig.GetRestResponse("CourseLevel/getAllCourseLevel", jwtToken);
            var courseLevel = JsonConvert.DeserializeObject<CourseLevelTypes>(apiResponse3);

            //Add Select option to the select List
            courseTypes.Data.Insert(0, new CourseTypeData { id = 0, courseTypeName = " Select Course Type" });
            courseCategory.Data.Insert(0, new CourseCategoryData { id = 0, courseCategoryName = "Select Category" });
            courseLevel.Data.Insert(0, new CourseLevelTypesData { id = 0, levelTypeName = "Select Course Level" });

            //Send the data to the View Bag
            ViewBag.CourseTypeList = courseTypes.Data;
            ViewBag.CourseCategoryList = courseCategory.Data;
            ViewBag.CourseLevelList = courseLevel.Data;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse(CourseCreateRequestModel model, [FromForm] IFormFile imageFile)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            var jwtToken = HttpContext.Session.GetString("Token");
            var userId = HttpContext.Session.GetString("UserId");

            //CourseType
            var apiResponse = await httpClientConfig.GetRestResponse("CourseType/getAllCourseType", jwtToken);
            var courseTypes = JsonConvert.DeserializeObject<CourseType>(apiResponse);

            //CourseCategory
            var apiResponse2 = await httpClientConfig.GetRestResponse("CourseCategory/getAllCourseCategory", jwtToken);
            var courseCategory = JsonConvert.DeserializeObject<CourseCategory>(apiResponse2);

            //CourseLevel
            var apiResponse3 = await httpClientConfig.GetRestResponse("CourseLevel/getAllCourseLevel", jwtToken);
            var courseLevel = JsonConvert.DeserializeObject<CourseLevelTypes>(apiResponse3);

            //Add Select option to the select List
            courseTypes.Data.Insert(0, new CourseTypeData { id = 0, courseTypeName = "Select Course Type" });
            courseCategory.Data.Insert(0, new CourseCategoryData { id = 0, courseCategoryName = "Select Category" });
            courseLevel.Data.Insert(0, new CourseLevelTypesData { id = 0, levelTypeName = "Select Course Level " });

            //Send the data to the View Bag
            ViewBag.CourseTypeList = courseTypes.Data;
            ViewBag.CourseCategoryList = courseCategory.Data;
            ViewBag.CourseLevelList = courseLevel.Data;

            
            model.FacilitatorId = new Guid(userId);

           


            string courseImageUrl = string.Empty;
            if (imageFile != null) //checks if the course Image is not null
            {
                //Image Upload to Cloudinary Instance
                var imageUploadResult = await _cloudinary.ImagesUpload(imageFile);
                courseImageUrl = imageUploadResult.Url.ToString();

                model.CourseImageUrl = courseImageUrl;

            }
            else
            {
                model.CourseImageUrl = "";
            }

            var restResponse = await httpClientConfig.PostRestResponseJson("Course/createCourse", model, jwtToken);
            //Response deserialized to Object Type specified
            var resp = JsonConvert.DeserializeObject<CreateResponseModel>(restResponse);

            if (resp.StatusCode == 200)
            {
                ViewData["message"] = resp.StatusMessage;

            }


            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = resp.StatusMessage;
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddCourseTopic() 
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            ViewData["Token"] = HttpContext.Session.GetString("Token");
            var jwtToken = HttpContext.Session.GetString("Token");
            long courseId = Convert.ToInt64(HttpContext.Request.Query["courseid"]);

            var UserId = HttpContext.Session.GetString("UserId");

            var apiResponse = await httpClientConfig.GetRestResponse("Course/allCourseByFacilitatorId?facilitatorId="+ UserId, jwtToken);
            var response = JsonConvert.DeserializeObject<CreateResponseModel>(apiResponse);

            CourseTopics CourseTopicList = new CourseTopics();
            var apiResponse1 = await httpClientConfig.ApiGetResponse("CourseTopics/allCourseTopicsByCourseId?courseId=" + courseId, jwtToken);
            CourseTopicList = JsonConvert.DeserializeObject<CourseTopics>(apiResponse1);
          
           // Send the data to the View Bag
             ViewBag.CourseTopicList = CourseTopicList.Data;

            ViewData["courseid"] = courseId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCourseTopic(CourseTopicsRequestModel model)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");

            var courseId = Convert.ToInt64(ViewData["courseid"]);
            var jwtToken = HttpContext.Session.GetString("Token");
            var userId = HttpContext.Session.GetString("UserId");


            model.FacilitatorId = new Guid(userId);
          //  model.CourseId = courseId;
           

            //Post Method Called
            var restResponse = await httpClientConfig.PostRestResponseJson("CourseTopics/createCourseTopics", model, jwtToken);

            var resp = JsonConvert.DeserializeObject<CreateResponseModel>(restResponse);

            if (resp.StatusCode == 200)
            {
                TempData["alert"] = "alert-success";
                ViewBag.Message = resp.StatusMessage;
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = resp.StatusMessage;
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddTopicMaterial(long coursetopicid)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            var jwtToken = HttpContext.Session.GetString("Token");
            var userId = HttpContext.Session.GetString("UserId");
            ViewData["coursetopicid"] = coursetopicid;

            var apiResponse = await httpClientConfig.GetRestResponse("CourseTopics/courseTopicMaterialsByCourseTopicId" + coursetopicid, jwtToken);
            var response = JsonConvert.DeserializeObject<CreateResponseModel>(apiResponse);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTopicMaterial(CourseTopicsMaterialsRequestModel model, [FromForm] IFormFile materialFile)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            var jwtToken = HttpContext.Session.GetString("Token");
            long courseId = Convert.ToInt64(HttpContext.Request.Query["courseid"]);
            long coursetopicId = Convert.ToInt64(HttpContext.Request.Query["coursetopicid"]);
            var userId = HttpContext.Session.GetString("UserId");

           

            if (materialFile != null) //checks if the course Image is not null
            {
                var documentUploadResult = await _cloudinary.DocumentUpload(materialFile);
                string fileExt = System.IO.Path.GetExtension(materialFile.FileName); //the file extension to determine the type e.g .pdf, .mp4, .mp3 etc
                string fileExtension = fileExt.Replace('.', ' ').Trim(); //removes "." from the file extension

                if(!fileExtension.Equals("pdf") && !fileExtension.Equals("doc") && !fileExtension.Equals("docx") && !fileExtension.Equals("xls") && !fileExtension.Equals("xlsx"))
                {
                    TempData["alert"] = "alert-danger";
                    ViewBag.Message = "Invalid File Format";
                    return View();
                }

                //--------write code to check the type of file before uploading to cloudinary
                model.FacilitatorId = new Guid(userId);
                model.CourseId = courseId;
                model.CourseTopicId = coursetopicId;
                model.FileName = materialFile.FileName;
                model.FileType = fileExtension;
                model.FileUrl = documentUploadResult.Url.ToString();
              

                var restResponse = await httpClientConfig.PostRestResponseJson("CourseTopics/createCourseTopicMaterial", model, jwtToken);

                //Response deserialized to Object Type specified
                var resp = JsonConvert.DeserializeObject<CreateResponseModel>(restResponse);

                if (resp.StatusCode == 200)
                {
                    ViewData["message"] = resp.StatusMessage;

                }

                else
                {
                    TempData["alert"] = "alert-danger";
                    ViewBag.Message = resp.StatusMessage;
                    return View(model);
                }

            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = "No file was selected!";
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddVideoContent(long coursetopicid)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            var jwtToken = HttpContext.Session.GetString("Token");
            var userId = HttpContext.Session.GetString("UserId");
            ViewData["coursetopicid"] = coursetopicid;

            var apiResponse = await httpClientConfig.GetRestResponse("CourseTopics/courseTopicVideosByCourseTopicId" + coursetopicid, jwtToken);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVideoContent(CourseAddVideoContent model, [FromForm] IFormFile materialFile)
        {
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            var jwtToken = HttpContext.Session.GetString("Token");
            long courseId = Convert.ToInt64(HttpContext.Request.Query["courseid"]);
            long coursetopicId = Convert.ToInt64(HttpContext.Request.Query["coursetopicid"]);
            var userId = HttpContext.Session.GetString("UserId");

            if (materialFile != null) //checks if the course Image is not null
            {
                var documentUploadResult = await _cloudinary.VideosUpload(materialFile);
                string fileExt = System.IO.Path.GetExtension(materialFile.FileName); //the file extension to determine the type e.g .pdf, .mp4, .mp3 etc
                string fileExtension = fileExt.Replace('.', ' ').Trim(); //removes "." from the file extension
                long filesize = materialFile.Length;

                if (!fileExtension.Equals("mp3") && !fileExtension.Equals("mp4"))
                {
                    TempData["alert"] = "alert-danger";
                    ViewBag.Message = "Kindly upload only mp3 and mp4 file format";
                    return View();
                }
                if (filesize > maximumFileSize)
                {
                    TempData["alert"] = "alert-danger";
                    ViewBag.Message = "File exceeds the maximum file size";
                    return View();
                }

                //--------write code to check the type of file before uploading to cloudinary
                model.FacilitatorId = new Guid(userId);
                model.CourseId = courseId;
                model.CourseTopicId = coursetopicId;
                model.FileName = materialFile.FileName;
                model.FileType = fileExtension;
                model.FileUrl = documentUploadResult.Url.ToString();

                var restResponse = await httpClientConfig.PostRestResponseJson("CourseTopics/createCourseTopicVideo", model, jwtToken);
                //Response deserialized to Object Type specified
                var resp = JsonConvert.DeserializeObject<CreateResponseModel>(restResponse);

                if (resp.StatusCode == 200)
                {
                    TempData["alert"] = "alert-success";
                    ViewData["message"] = resp.StatusMessage;

                }
                else
                {
                    TempData["alert"] = "alert-danger";
                    ViewBag.Message = resp.StatusMessage;
                    return View(model);
                }
            }
            else
            {
                TempData["alert"] = "alert-danger";
                ViewBag.Message = "No file was selected!";
            }

            return View();
        }
    }
}
