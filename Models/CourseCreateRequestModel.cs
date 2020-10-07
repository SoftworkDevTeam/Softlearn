using Microsoft.AspNetCore.Http;
using SoftLearnFrontEnd.ResponseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearn.Models
{
    public class CourseCreateRequestModel
    {
        [Required]
        public Guid FacilitatorId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseDescription { get; set; }
        public string CourseImageUrl { get; set; }
        [Required]
        public long CourseTypeId { get; set; }
        [Required]
        public long LevelTypeId { get; set; }
        [Required]
        public long CourseCategoryId { get; set; }
        public string AboutCourse { get; set; }
        [Required]
        public long CourseAmount { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
