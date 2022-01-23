using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Entities
{
    public class CartItem : Entity
    {
        public int Quantity { get; set; }

        public string CartId { get; set;}
        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
