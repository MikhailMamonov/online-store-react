using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Entities
{
    public class Order : Entity
    {
        public string ZipCode { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public decimal OrderTotal { get; set; }

        public DateTime OrderPlaced { get; set; }
    }
}
