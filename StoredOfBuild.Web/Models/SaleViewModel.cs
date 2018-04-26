﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoredOfBuild.Web.Models
{
    
    public class SaleViewModel
    {
        [Required]
        public string ClientName { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}

