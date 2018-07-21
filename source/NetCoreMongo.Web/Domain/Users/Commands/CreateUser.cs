using System;
using System.Collections.Generic;
using AspNetCoreMongoDb.Web.Domain.Users.Models;

namespace AspNetCoreMongoDb.Web.Domain.Users.Commands
{
    public class CreateUser
    {
        public CreateUser()
        {
            Emails = new List<UserEmailItem>();
        }

        public string Name { get; set; }
        public Guid ProfessionId { get; set; }
        public IEnumerable<UserEmailItem> Emails { get; }
        public Guid CountryId { get; internal set; }
    }
}
