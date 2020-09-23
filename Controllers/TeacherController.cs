using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.RequestModels;
using SoftLearnFrontEnd.ResponseModels;

namespace SoftLearn.Controllers
{
    public class TeacherController : Controller
    {
        HttpClientConfig httpClientConfig = new HttpClientConfig();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //public IActionResult CreateTeacher()
        //{
        //    return View();
        //}

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
       
    }
}
