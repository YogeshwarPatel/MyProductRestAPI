using System;

namespace MyProductCore.EntityLayer
{
    public interface IAuditableEntity : IEntity
    {
        String CreationUser { get; set; }

        DateTime? CreationDateTime { get; set; }

        String LastUpdateUser { get; set; }

        DateTime? LastUpdateDateTime { get; set; }
    }
}
