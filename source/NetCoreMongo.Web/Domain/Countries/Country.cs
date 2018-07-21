using System;

namespace AspNetCoreMongoDb.Web.Domain.Countries
{
    public class Country
    {
        public Country(string desription, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Desription = desription;
        }

        public Guid Id { get; private set; }
        public string Desription { get; private set; }
    }
}
