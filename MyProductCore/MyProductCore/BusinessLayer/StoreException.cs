using System;

namespace MyProductCore.BusinessLayer
{
    public class MyProductException : Exception
    {
        public MyProductException()
            : base()
        {
        }

        public MyProductException(String message)
            : base(message)
        {
        }

        public MyProductException(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
