using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class AssignTeacherToClassRequestModel
    {
        [Required]
        public Guid TeacherId { get; set; }
        [Required]
        public long ClassId { get; set; }
        [Required]
        public long ClassGradeId { get; set; }
        [Required]
        public long SchoolId { get; set; }
    }

    public class StudentId
    {
        public Guid Id { get; set; }
    }

    public class AssignStudentToClassRequestModel
    {
        [Required]
        public long ClassId { get; set; }
        [Required]
        public long ClassGradeId { get; set; }
        [Required]
        public long SchoolId { get; set; }
        [Required]
        public IEnumerable<StudentId> StudentIds { get; set; }
    }
}
