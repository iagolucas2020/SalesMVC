using System;

namespace SalesMvcEntityFramework.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) : base(message)
        {
        }
    }
}
