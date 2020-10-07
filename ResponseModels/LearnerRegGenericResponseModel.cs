using NewSoftlearn.ResponseModels;
using SoftLearnFrontEnd.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearn.ResponseModels
{
    public class LearnerRegGenericResponseModel
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Token { get; set; }
        public LearnerRegResponseModel Data { get; set; }
    }

    public class FacRegGenericResponseModel
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Token { get; set; }
        public FacilitatorRegResponseModel Data { get; set; }
    }

    public class FacLoginGenericResponseModel
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Token { get; set; }
        public FacilitatorLoginResponseModel Data { get; set; }
    }

    public class SchoolRegGenericResponseModel
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Token { get; set; }
        public SchoolUserInfoResponseModel Data { get; set; }
    }

    public class TeacherRegGenericResponseModel
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Token { get; set; }
        public TeacherCreateResponseModel Data { get; set; }
    }
    public class CoursesGenericResponseModel
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Token { get; set; }
        public CoursesCreateResponseModel Data { get; set; }
    }
}
