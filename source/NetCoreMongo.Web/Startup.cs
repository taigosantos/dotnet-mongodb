using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using NetCoreMongo.Web.Data.Context;
using NetCoreMongo.Web.Data.Mappings;
using NetCoreMongo.Web.Data.Repositories;
using NetCoreMongo.Web.Data.Seed;
using NetCoreMongo.Web.Domain.Users.Repository;

namespace NetCoreMongo.Web
{
    public class Startup
    {
        #region Constructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Properties

        public IConfiguration Configuration { get; }

        #endregion

        #region Public Methods

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Context 

            var mongoClient = new MongoClient(Configuration.GetSection("mongo:connectionString").Value);
            var mongoDatabase = mongoClient.GetDatabase(Configuration.GetSection("mongo:database").Value);

            services.AddScoped(context => new UsersContext(mongoDatabase));

            // Mongo Mappings

            EntityMappings.RegisterEntityMappings();
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

        #endregion
    }
}