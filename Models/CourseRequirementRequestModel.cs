using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class CourseRequirementRequestModel
    {
        public long CourseId { get; set; }
        public string Requirement { get; set; }
    }
}
