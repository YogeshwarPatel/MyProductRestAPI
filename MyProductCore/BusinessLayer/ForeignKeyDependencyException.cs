using System;

namespace MyProductCore.BusinessLayer
{
    public class ForeignKeyDependencyException : MyProductException
    {
        public ForeignKeyDependencyException()
        {
        }

        public ForeignKeyDependencyException(String message)
            : base(message)
        {
        }
    }
}
