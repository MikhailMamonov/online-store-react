﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Core.Entities.Base
{
    public interface IEntityBase<TId>
    {
            TId Id { get; }
    }
}
