using Raven.DependencyInjection;

namespace IdentityRavenDbWebApplication1
{
    public static class RavenDbConfiguration
    {
        public static void ConfigureRavenDb(this IServiceCollection services)
        {
            services
            .AddRavenDbDocStore() // Create our IDocumentStore singleton using the database settings in appsettings.json
            .AddRavenDbAsyncSession(); // Create an Raven IAsyncDocumentSession for every request.
        }
    }
}
