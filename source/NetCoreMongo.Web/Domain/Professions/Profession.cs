using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMongoDb.Web.Domain.Professions
{
    public class Profession
    {
        public Profession(string desription, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Desription = desription;
        }

        public Guid Id { get; private set; }
        public string Desription { get; private set; }
    }
}
