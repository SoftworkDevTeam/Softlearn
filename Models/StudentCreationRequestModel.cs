using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLearnFrontEnd.RequestModels
{
    public class StudentCreationRequestModel
    {
        [Required]
        public long SchoolId { get; set; }
        [Required]
        public string StudentFirstName { get; set; }
        [Required]
        public string StudentLastName { get; set; }
        [Required]
        public string AdmissionNumber { get; set; }

        [Required]
        public string ParentFirstName { get; set; }
        [Required]
        public string ParentLastName { get; set; }
        public string ParentUserName { get; set; }
        [Required]
        public string ParentEmail { get; set; }
        [Required]
        public string ParentPhoneNumber { get; set; }

    }

    public class StudentParentExistCreationRequestModel
    {
        [Required]
        public long SchoolId { get; set; }
        [Required]
        public Guid ParentId { get; set; }
        [Required]
        public string StudentFirstName { get; set; }
        [Required]
        public string StudentLastName { get; set; }
        [Required]
        public string AdmissionNumber { get; set; }

    }
}
