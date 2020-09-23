using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.ResponseModels
{
    public class SchoolBasicInfoResponseModel
    {
        public Guid SchoolAdministratorId {get; set;}
        public long SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCode { get; set; }
        public long SchoolTypeId { get; set; }
        public string SchoolTypeName { get; set; }
        public string Address { get; set; }
    }
}
