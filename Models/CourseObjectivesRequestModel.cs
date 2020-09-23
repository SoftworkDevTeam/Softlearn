using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class CourseObjectivesRequestModel
    {
        [Required]
        public long CourseId { get; set; }
        [Required]
        public string Objective { get; set; }
    }
}
