using System;
using System.Collections.Generic;
using System.Text;

namespace Claro.Business.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Code = Guid.NewGuid();
        }

        public Guid Code { get; set; }
    }
}
