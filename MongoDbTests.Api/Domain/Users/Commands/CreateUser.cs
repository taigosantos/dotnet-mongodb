using System;
using System.Collections.Generic;

namespace MongoDbTests.Api.Domain.Users.Commands
{
    public class CreateUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<CreateUserPhone> Phones { get; set; }
    }
}
