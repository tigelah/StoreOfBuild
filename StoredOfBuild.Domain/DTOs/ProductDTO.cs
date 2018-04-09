using System;
using System.Collections.Generic;
using System.Text;

namespace StoredOfBuild.Domain.DTOs
{
   public class ProductDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Categoryid { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
    }
}
