using System;
using System.Collections.Generic;

namespace MongoDbTests.Api.Domain.Users
{
    public class User
    {
        private List<UserPhone> _phones = new List<UserPhone>();

        public User(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public IReadOnlyCollection<UserPhone> Phones => _phones.AsReadOnly();

        public void AddPhone(string ddd, string number)
        {
            var phone = new UserPhone(Id, ddd, number);

            _phones.Add(phone);
        }
    }
}
