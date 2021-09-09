using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VillageBoard.EntityFrameworkCore
{
    public static class VillageBoardDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VillageBoardDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VillageBoardDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
