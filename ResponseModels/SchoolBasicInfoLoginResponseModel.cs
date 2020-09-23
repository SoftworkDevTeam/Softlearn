using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.ResponseModels
{
    public class SchoolBasicInfoLoginResponseModel
    {
        public long SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCode { get; set; }
        public string SchoolTypeName { get; set; }
        public string Address { get; set; }
    }
}
