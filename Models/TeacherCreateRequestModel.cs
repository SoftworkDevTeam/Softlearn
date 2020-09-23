using SoftLearnFrontEnd.ResponseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class TeacherCreateRequestModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public object SchoolType { get; set; }
        public IEnumerable<TeacherRoles> teacherRole  { get; set; }

        public IEnumerable<SchoolName> School { get; set; }

        //public long SchooltypeId { get; set; }
        [Required]
        public long teacherRoleId { get; set; }

    }
}
