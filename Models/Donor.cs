﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRM.Models
{
    public class Donor
    {
        [Key]
        public int DDonor { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Num_Gifts { get; set; }
        public int LT_Amt { get; set; }
    }
}
