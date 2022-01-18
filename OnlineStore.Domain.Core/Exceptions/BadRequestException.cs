using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Core.Exceptions
{
    public abstract class BadRequestException : Exception
    {
        protected BadRequestException(string message)
            : base(message)
        {
        }
    }
}
