using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Interfaces.Base
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
