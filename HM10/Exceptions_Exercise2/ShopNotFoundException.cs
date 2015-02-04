using System;

namespace Exceptions_Exercise2
{
    class ShopNotFoundException : Exception
    {
        public ShopNotFoundException() : base()
        {
        }

        public ShopNotFoundException(String message) : base(message)
        {
        }
    }
}
