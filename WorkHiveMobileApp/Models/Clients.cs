﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHiveMobileApp.ViewModel
{
    public class Clients:Users
    {
        public string CompanyName { get; set; }

        public string Website { get; set; }
    }
}
