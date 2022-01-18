using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public short? UnitsInStock { get; set; }


        public virtual Category Category { get; set; }
        //public virtual ICollection<CartItem> CartItems { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
