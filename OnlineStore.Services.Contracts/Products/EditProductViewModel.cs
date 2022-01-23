using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Services.Contracts.Products
{
    public class EditProductViewModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public short? UnitsInStock { get; set; }
    }
}
