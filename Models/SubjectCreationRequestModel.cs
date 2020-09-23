using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class SubjectCreationRequestModel
    {
        [Required]
        public long ClassId { get; set; }
        [Required]
        public long SchoolId { get; set; }
        [Required]
        public string SubjectName { get; set; }

    }
}
