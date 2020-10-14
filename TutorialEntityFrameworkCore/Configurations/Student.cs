﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.sun.tools.doclets.formats.html.resources;

namespace Configurations
{
    [Table("StudentInfo")]
    public class Student
    {
        public Student() { }

        [Key]
        public int SID { get; set; }

        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [NotMapped]
        public int? Age { get; set; }


        public int StdId { get; set; }

        [ForeignKey("StdId")]
        public virtual standard Standard { get; set; }
    }
}