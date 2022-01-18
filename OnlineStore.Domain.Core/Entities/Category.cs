using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; private set; }
    }
}
