using System;
using System.Collections.Generic;
using AspNetCoreMongoDb.Web.Data.Context;
using AspNetCoreMongoDb.Web.Domain.Countries;
using AspNetCoreMongoDb.Web.Domain.Professions;
using AspNetCoreMongoDb.Web.Domain.Users;
using MongoDB.Driver;

namespace AspNetCoreMongoDb.Web.Data.Seed
{
    public static class UsersContextSeed
    {
        public static void Seed(this UsersContext usersContext)
        {
            usersContext
                .Clear()
                .SeedProfessions()
                .SeedCountries()
                .SeedUsers()
                ;
        }

        private static UsersContext Clear(this UsersContext usersContext)
        {
            usersContext.Users.DeleteMany(u => true);
            usersContext.Professions.DeleteMany(u => true);
            usersContext.Countries.DeleteMany(u => true);

            return usersContext;
        }

        private static UsersContext SeedUsers(this UsersContext usersContext)
        {
            var usersList = new List<User>();

            // USER 1

            var user1 = new User(
                id: new Guid("348cd68f-41a6-404b-91db-9eeb3b5e88d0"),
                professionId: new Guid("197ab134-06a2-49aa-a80b-b46daba8d506"),
                countryId: new Guid("52f84c95-6d1a-4723-8853-71a23a6ae10d"),
                name: "Amauri Santos"
                );

            user1.AddEmail(
                id: new Guid("171922f5-15ed-4658-8b45-ffc3a5980d23"), 
                address: "amauri@email.com"
                );

            user1.AddEmail(
                id: new Guid("47ab31a1-27c8-4347-ab03-2ec642cd967f"),
                address: "amauri.santos@email.com"
                );

            usersList.Add(user1);

            // USER 2

            var user2 = new User(
                id: new Guid("bd406049-c7bf-41dd-8ea9-fa86e094b479"),
                professionId: new Guid("841eb44d-0704-491a-ad6d-51d2bc3ecc60"),
                countryId: new Guid("52f84c95-6d1a-4723-8853-71a23a6ae10d"),
                name: "Alan Santos"
                );

            usersList.Add(user2);

            // USER 3

            var user3 = new User(
                id: new Guid("917b7f78-38b7-4234-84be-9da6bdd66d95"),
                professionId: new Guid("8d5d8e35-20bf-4129-ae36-8f535b0b2d5f"),
                countryId: new Guid("802f4490-3692-48e9-8537-6ab7555f6457"),
                name: "Roberto Justo"
                );

            usersList.Add(user3);

            // USER 4

            var user4 = new User(
                id: new Guid("6f031514-2ec1-40d7-b8f9-0c68d737d8e7"),
                professionId: new Guid("841eb44d-0704-491a-ad6d-51d2bc3ecc60"),
                countryId: new Guid("802f4490-3692-48e9-8537-6ab7555f6457"),
                name: "Josi Reis"
                );

            usersList.Add(user4);


            usersContext.Users.InsertMany(usersList);

            return usersContext;
        }

        private static UsersContext SeedProfessions(this UsersContext usersContext)
        {
            var professionsList = new List<Profession>();

            // PROFESSION 1

            var profession1 = new Profession(
                id: new Guid("197ab134-06a2-49aa-a80b-b46daba8d506"),
                desription: "Desenvolvedor"
                );

            professionsList.Add(profession1);

            // PROFESSION 2

            var profession2 = new Profession(
                id: new Guid("841eb44d-0704-491a-ad6d-51d2bc3ecc60"),
                desription: "Designer"
                );

            professionsList.Add(profession2);

            // PROFESSION 3

            var profession3 = new Profession(
                id: new Guid("8d5d8e35-20bf-4129-ae36-8f535b0b2d5f"),
                desription: "Arquiteto"
                );

            professionsList.Add(profession3);


            usersContext.Professions.InsertMany(professionsList);

            return usersContext;
        }

        private static UsersContext SeedCountries(this UsersContext usersContext)
        {
            var countriesList = new List<Country>();

            // COUNTRY 1

            var country1 = new Country(
                id: new Guid("52f84c95-6d1a-4723-8853-71a23a6ae10d"),
                desription: "Brasil"
                );

            countriesList.Add(country1);

            // COUNTRY 2

            var country2 = new Country(
                id: new Guid("802f4490-3692-48e9-8537-6ab7555f6457"),
                desription: "México"
                );

            countriesList.Add(country2);

            usersContext.Countries.InsertMany(countriesList);

            return usersContext;
        }
    }
}
