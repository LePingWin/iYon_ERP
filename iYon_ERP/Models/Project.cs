﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
     public class Project
    {
        private string Name { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime LimiteDate { get; set; }
        private int DevCharge { get; set; }
        private int ProjectManagementCharge { get; set; }
        private float Efficience { get; set; }
    }
}