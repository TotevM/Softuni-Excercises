﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;

namespace CarDealer.DTOs.Export
{
    public class SupplierDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PartsCount { get; set; }
    }
}