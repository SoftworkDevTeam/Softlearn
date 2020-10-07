using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.Entities
{
    public class CourseDataResponse
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public IList<CourseData> Data { get; set; }
    }

    public class CourseData
    {
        public long id { get; set; }
        public string facilitatorId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public string courseImageUrl { get; set; }
        public string aboutCourse { get; set; }
        public string courseCategoryName { get; set; }
        public string levelTypeName { get; set; }
        public string courseTypeName { get; set; }
        public long courseAmount { get; set; }
        public bool isApproved { get; set; }
        public bool isVerified { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
