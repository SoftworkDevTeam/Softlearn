using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.Entities
{
    public class CourseLevelTypes
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public IList<CourseLevelTypesData> Data { get; set; }
    }

    public class CourseLevelTypesData
    {
        public long id { get; set; }
        public string levelTypeName { get; set; }

    }
}
