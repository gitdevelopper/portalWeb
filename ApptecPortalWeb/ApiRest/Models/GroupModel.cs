﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRest.Models
{
    public class GroupModel
    {
        public int GroupId { get; set; }
        public string Nombre { get; set; }
        public string Users { get; set; }
    }
}