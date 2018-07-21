using System;

namespace AspNetCoreMongoDb.Web.Domain.Users
{
    public class UserEmail
    {
        public UserEmail(string address, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Address = address;
        }

        public Guid Id { get; private set; }
        public string Address { get; private set; }

        public void Update(string address)
        {
            Address = address;
        }
    }
}
