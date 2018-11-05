using System.Collections.Generic;
using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Domain.Users
{
    public class User : Entity
    {
        #region Fields

        private List<UserEmail> _emails = new List<UserEmail>();

        #endregion

        #region Constructors

        public User(string name, string professionId, string countryId, string id = null)
            : base(id)
        {
            Name = name;
            ProfessionId = professionId;
            CountryId = countryId;
        }

        #endregion

        #region Properties

        public string Name { get; private set; }
        public string ProfessionId { get; private set; }
        public string CountryId { get; private set; }
        public IReadOnlyList<UserEmail> Emails => _emails.AsReadOnly();

        #endregion

        #region Public Methods

        public void Update(string name, string professionId, string countryId)
        {
            Name = name;
            ProfessionId = professionId;
            CountryId = countryId;
        }

        public void AddEmail(string address, string id = null)
        {
            var userEmail = new UserEmail(address, id);

            _emails.Add(userEmail);
        }

        #endregion
    }
}