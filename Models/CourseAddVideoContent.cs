﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.Models
{
    public class CourseAddVideoContent
    {
        [Required]
        public Guid FacilitatorId { get; set; }
        [Required]
        public long CourseId { get; set; }
        [Required]
        public long CourseTopicId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
    }
}