﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Required, StringLength(100)]
        public string ProductName { get; set; }
        [Range(0, 9999999)]
        public decimal UnitPrice { get; set; }

        public int CritickStock { get; set; }
        public string Display => $"{this.ProductName} - {this.UnitPrice :c2}";
    }
}
