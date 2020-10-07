using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.Entities
{
    public class CourseType
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public IList<CourseTypeData> Data { get; set; }
    }

    public class CourseTypeData
    {
        public long id { get; set; }
        public string courseTypeName { get; set; }
        public string courseName { get; set; }

    }
}
