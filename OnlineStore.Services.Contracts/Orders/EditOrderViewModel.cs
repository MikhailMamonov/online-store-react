﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Services.Contracts.Orders
{
    public class EditOrderViewModel
    {
        public string ZipCode { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public decimal OrderTotal { get; set; }
    }
}
