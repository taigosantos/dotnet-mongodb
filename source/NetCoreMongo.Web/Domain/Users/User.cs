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

        public User(string name, UserProfession profession, UserCountry country, string id = null)
            : base(id)
        {
            Name = name;
            Profession = profession;
            Country = country;
        }

        #endregion

        #region Properties

        public string Name { get; private set; }
        public UserProfession Profession { get; private set; }
        public UserCountry Country { get; private set; }
        public IReadOnlyList<UserEmail> Emails => _emails.AsReadOnly();

        #endregion

        #region Public Methods

        public void Update(string name, UserProfession profession, UserCountry country)
        {
            Name = name;
            Profession = profession;
            Country = country;
        }

        public void AddEmail(string address, string id = null)
        {
            var userEmail = new UserEmail(address, id);

            _emails.Add(userEmail);
        }

        #endregion
    }
}