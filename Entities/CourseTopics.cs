using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.Entities
{
    public class CourseTopics
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public IList<CourseTopicData> Data { get; set; }
    }

    public class CourseTopicData
    {
        public long id { get; set; }
        public string facilitatorId { get; set; }
        public long courseId { get; set; }
        public string courseName { get; set; }
        public string topic { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
