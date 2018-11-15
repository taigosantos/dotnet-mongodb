using System.Collections.Generic;
using NetCoreMongo.Web.Domain.Users.Models;

namespace NetCoreMongo.Web.Domain.Users.Commands
{
    public class CreateUser
    {
        #region Constructors

        public CreateUser()
        {
            Emails = new List<UserEmailItem>();
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public string ProfessionId { get; set; }
        public string Profession { get; set; }
        public string CountryId { get; internal set; }
        public string Country { get; set; }
        public IEnumerable<UserEmailItem> Emails { get; }

        #endregion
    }
}