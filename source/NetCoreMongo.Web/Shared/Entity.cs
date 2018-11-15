using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMongo.Web.Shared
{
    public abstract class Entity
    {
        protected Entity(string id)
        {
            Id = id ?? Identity.NewId();
        }

        public string Id { get; private set; }
        public bool IsRemoved { get; private set; }

        public void Remove()
        {
            IsRemoved = true;
        }
    }
}
