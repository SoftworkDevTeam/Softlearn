﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.ResponseModels
{
    public class CoursesCreateResponseModel
    {
        [Required]
        public long id { get; set; }
        public Guid facilitatorId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public string courseImageUrl { get; set; }
        public string aboutCourse { get; set; }
        public string courseCategoryName { get; set; }
        public string levelTypeName { get; set; }

        public string courseTypeName { get; set; }

        public long courseAmount { get; set; }
        public bool isApproved { get; set; }
        public bool isVerified { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
