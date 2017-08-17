using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Phoogle.Configuration;
using Phoogle.Web;

namespace Phoogle.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoogleDbContextFactory : IDbContextFactory<PhoogleDbContext>
    {
        public PhoogleDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<PhoogleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoogleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoogleConsts.ConnectionStringName));
            
            return new PhoogleDbContext(builder.Options);
        }
    }
}