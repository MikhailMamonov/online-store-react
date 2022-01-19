using System;

namespace OnlineStore.Services.Contracts
{
    public class OrderDto
    {
        public string ZipCode { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public decimal OrderTotal { get; set; }

        public DateTime OrderPlaced { get; set; }
    }
}
