﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRest.Models
{
    public class CareerModel
    {
       public int CareerId { get; set; } 
       public string Clave { get; set; }
       public string Nombre { get; set; }
       public int  InstitucionId { get; set; }
       public string Users { get; set; }

    }
}