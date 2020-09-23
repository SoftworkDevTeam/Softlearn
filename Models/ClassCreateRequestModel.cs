using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class ClassCreateRequestModel
    {
        [Required]
        public string ClassName { get; set; }
        [Required]
        public long SchoolId { get; set; }
    }
}
