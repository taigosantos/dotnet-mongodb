using AspNetCoreMongoDb.Web.Data.Context;
using AspNetCoreMongoDb.Web.Data.Mappings;
using AspNetCoreMongoDb.Web.Data.Repositories;
using AspNetCoreMongoDb.Web.Data.Seed;
using AspNetCoreMongoDb.Web.Domain.Users.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace AspNetCoreMongoDb.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Context 

            var mongoClient = new MongoClient(Configuration.GetSection("mongo:connectionString").Value);
            var mongoDatabase = mongoClient.GetDatabase(Configuration.GetSection("mongo:database").Value);

            services.AddScoped(context => new UsersContext(mongoDatabase));

            // Mongo Mappings

            UsersMappings.RegisterUsersMappings();
            ProfessionsMappings.RegisterProfessionsMappings();
            CountriesMappings.RegisterCountriesMappings();

            // Repositories

            services.AddScoped<IUserRepository, UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UsersContext usersContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            usersContext.Seed();

            app.UseMvc();
        }
    }
}
