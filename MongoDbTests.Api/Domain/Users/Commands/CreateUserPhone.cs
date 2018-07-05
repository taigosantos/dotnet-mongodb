using System;

namespace MongoDbTests.Api.Domain.Users.Commands
{
    public class CreateUserPhone
    {
        public Guid Id { get; set; }
        public string Ddd { get; set; }
        public string Number { get; set; }
    }
}
