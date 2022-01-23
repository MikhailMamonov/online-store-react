using System;

namespace OnlineStore.Services.Contracts.Orders
{
    public class IndexOrderViewModel
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public decimal OrderTotal { get; set; }

    }
}
