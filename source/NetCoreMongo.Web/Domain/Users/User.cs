using System.Collections.Generic;
using NetCoreMongo.Web.Domain.Countries;
using NetCoreMongo.Web.Domain.Professions;
using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Domain.Users
{
    public class User : Entity
    {
        #region Fields

        private List<UserEmail> _emails = new List<UserEmail>();

        public User(string name, Profession profession, Country country, string id = null)
            : base(id)
        {
            Name = name;
            Profession = profession;
            Country = country;
        }

        #endregion

        #region Constructors



        #endregion

        #region Properties

        public string Name { get; private set; }
        public Profession Profession { get; private set; }
        public Country Country { get; private set; }
        public IReadOnlyList<UserEmail> Emails => _emails.AsReadOnly();

        #endregion

        #region Public Methods

        public void Update(string name, Profession profession, Country country)
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