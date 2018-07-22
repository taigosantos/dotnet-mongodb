using System;
using System.Collections.Generic;
using AspNetCoreMongoDb.Web.Domain.Professions;

namespace AspNetCoreMongoDb.Web.Domain.Users
{
    public class User
    {
        private List<UserEmail> _emails;

        public User(string name, Guid professionId, Guid countryId, Guid? id = null)
            : this()
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            ProfessionId = professionId;
            CountryId = countryId;
        }

        public User()
        {
            _emails = new List<UserEmail>();
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid ProfessionId { get; private set; }
        public Guid CountryId { get; private set; }
        public IReadOnlyCollection<UserEmail> Emails => _emails.AsReadOnly();

        public void Update(string name, Guid professionId, Guid countryId)
        {
            Name = name;
            ProfessionId = professionId;
            CountryId = countryId;
        }

        public void AddEmail(string address, Guid? id = null)
        {
            var userEmail = new UserEmail(address, id);

            _emails.Add(userEmail);
        }
    }
}
