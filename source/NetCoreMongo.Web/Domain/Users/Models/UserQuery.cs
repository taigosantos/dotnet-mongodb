using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreMongo.Web.Domain.Countries;
using NetCoreMongo.Web.Domain.Professions;

namespace NetCoreMongo.Web.Domain.Users.Models
{
    public class UserQuery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Profession Profession { get; set; }
        public Country Country { get; set; }
    }
}
