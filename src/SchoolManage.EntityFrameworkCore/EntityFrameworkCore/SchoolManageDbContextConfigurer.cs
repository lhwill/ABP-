using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SchoolManage.EntityFrameworkCore
{
    public static class SchoolManageDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchoolManageDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SchoolManageDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
