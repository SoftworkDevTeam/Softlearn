using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.ResponseModels
{
    public class SuperAdminCreateResponse
    {
        public long StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string  Token { get; set; }
        public object Data { get; set; }
    }
}
