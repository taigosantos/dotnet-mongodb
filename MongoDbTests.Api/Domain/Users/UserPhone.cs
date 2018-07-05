using System;

namespace MongoDbTests.Api.Domain.Users
{
    public class UserPhone
    {
        public UserPhone(Guid userId, string ddd, string number)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Ddd = ddd;
            Number = number;
        }

        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Ddd { get; private set; }
        public string Number { get; private set; }


    }
}
