﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHiveMobileApp.ViewModel
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
