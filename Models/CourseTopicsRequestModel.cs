using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class CourseTopicsRequestModel
    {
        [Required]
        public Guid FacilitatorId { get; set; }
        [Required]
        public long CourseId { get; set; }
        [Required]
        public string Topic { get; set; }
        [Required]
        public string Duration { get; set; }
    }
}
