using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMongoDb.Web.Domain.Users.Models
{
    public class UserItem
    {
        public Guid Id { get; internal set; }
        public string Name { get; internal set; }
        public string Profission { get; internal set; }
        public string Country { get; internal set; }
    }
}
