using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.Entities
{
    public class CourseCategory
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public IList<CourseCategoryData> Data { get; set; }

    }
    public class SingleCourseCategory
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public CourseCategoryData Data { get; set; }

    }
    public class CourseCategoryData
    {
        public long id { get; set; }
        public string courseCategoryName { get; set; }

        public string categoryImageUrl { get; set; }
    }
}
