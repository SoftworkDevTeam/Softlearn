﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
 
    public class AssignSubjectToTeacherRequestModel
    {
        [Required]
        public Guid TeacherId { get; set; }
        [Required]
        public long SchoolId { get; set; }
        [Required]
        public IEnumerable<SubjectId> SubjectIds { get; set; }
    }
    public class SubjectId
    {
        public long Id { get; set; }
    }
}
