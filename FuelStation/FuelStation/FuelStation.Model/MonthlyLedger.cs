﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models
{
    public class MonthlyLedger
    {
        public int Year { get; set; }
        public int Month { get; set; }

        public decimal Income { get; set; }
        public decimal Expences { get; set; }
        public decimal Total { get; set; }
    }
}
