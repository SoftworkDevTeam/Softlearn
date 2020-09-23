using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.ResponseModels
{
    public class SchoolTypes
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public IEnumerable<Data> Data { get; set; }
    }

    public class TeacherRoles
    {
        public int id { get; set; }
        public string roleName { get; set; }
    }
    public class SchoolName
    {
        public int id { get; set; }
        public int roleName { get; set; } 
    }
    public class Data
    {
        public long Id { get; set; }
        public string SchoolTypeName { get; set; }
    }
    public class SchoolTypeList
    {
        public long id { get; set; }
        public string SchoolTypeName { get; set; }
    }
    public class CourseTypes
    {
        public long id { get; set; }
        public string courseTypeName { get; set; }
    }
    public class CourseCategory
    {
        public long id { get; set; }
        public string courseCategoryName { get; set; }
    }
    public class CourseLevel
    {
        public long id { get; set; }
        public string levelTypeName { get; set; }
    }
}

