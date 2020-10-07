using SoftLearnFrontEnd.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearn.Models
{
    public class CourseDropdownRequestModel
    {
        public IEnumerable<CourseTypes> CourseTypes { get; set; }

        public IEnumerable<CourseLevel> CourseLevel { get; set; }

       // public IEnumerable<CourseCategory> CourseCategory { get; set; }
    }
}
