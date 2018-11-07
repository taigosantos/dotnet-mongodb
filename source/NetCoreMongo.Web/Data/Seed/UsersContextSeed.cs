using System.Collections.Generic;
using MongoDB.Driver;
using NetCoreMongo.Web.Data.Context;
using NetCoreMongo.Web.Domain.Countries;
using NetCoreMongo.Web.Domain.Professions;
using NetCoreMongo.Web.Domain.Users;

namespace NetCoreMongo.Web.Data.Seed
{
    public static class UsersContextSeed
    {
        #region Public Methods

        public static void Seed(this UsersContext usersContext)
        {
            var countries = GetCountries();
            var professions = GetProfessions();
            var users = GetUsers(countries, professions);

            usersContext.Clear();

            usersContext.Countries.InsertMany(countries);
            usersContext.Professions.InsertMany(professions);
            usersContext.Users.InsertMany(users);
        }

        #endregion

        #region Private Methods

        private static void Clear(this UsersContext usersContext)
        {
            usersContext.Users.DeleteMany(u => true);
            usersContext.Professions.DeleteMany(u => true);
            usersContext.Countries.DeleteMany(u => true);
        }

        private static IEnumerable<User> GetUsers(IList<Country> countries, IList<Profession> professions)
        {
            var usersList = new List<User>();

            // USER 1

            var user1 = new User(
                professionId: professions[1].Id,
                countryId: countries[0].Id,
                name: "Amauri Santos"
            );

            user1.AddEmail("amauri@email.com");
            user1.AddEmail("amauri.santos@email.com");

            usersList.Add(user1);

            // USER 2

            var user2 = new User(
                professionId: professions[0].Id,
                countryId: countries[0].Id,
                name: "Alan Santos"
            );

            usersList.Add(user2);

            // USER 3

            var user3 = new User(
                professionId: professions[1].Id,
                countryId: countries[1].Id,
                name: "Roberto Justo"
            );

            usersList.Add(user3);

            // USER 4

            var user4 = new User(
                professionId: professions[2].Id,
                countryId: countries[1].Id,
                name: "Josi Reis"
            );

            usersList.Add(user4);


            return usersList;
        }

        private static IList<Profession> GetProfessions()
        {
            var professionsList = new List<Profession>();

            // PROFESSION 1

            var profession1 = new Profession("Desenvolvedor");
            professionsList.Add(profession1);

            // PROFESSION 2

            var profession2 = new Profession("Designer");
            professionsList.Add(profession2);

            // PROFESSION 3

            var profession3 = new Profession("Arquiteto");
            professionsList.Add(profession3);

            return professionsList;
        }

        private static IList<Country> GetCountries()
        {
            var countriesList = new List<Country>();

            // COUNTRY 1

            var country1 = new Country("Brasil");
            countriesList.Add(country1);

            // COUNTRY 2

            var country2 = new Country("México");
            countriesList.Add(country2);

            return countriesList;
        }

        #endregion
    }
}