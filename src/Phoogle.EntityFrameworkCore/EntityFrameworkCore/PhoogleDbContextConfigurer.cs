using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Phoogle.EntityFrameworkCore
{
    public static class PhoogleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoogleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}