using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.AspNetCore.Identity;

using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Entities
{
    public class User : IdentityUser<int>, IEntityBase<int>
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
