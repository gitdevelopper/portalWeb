﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRest.Models
{
    public class DegreeSubjectModel
    {
        public int DegreeSubjectId { get; set; }
        public int DegreeId { get; set; }
        public int SubjectId { get; set; }
        public string Users { get; set; }
    }
}