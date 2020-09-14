using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SchoolManage.Configuration;
using SchoolManage.Web;

namespace SchoolManage.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SchoolManageDbContextFactory : IDesignTimeDbContextFactory<SchoolManageDbContext>
    {
        public SchoolManageDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SchoolManageDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SchoolManageDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SchoolManageConsts.ConnectionStringName));

            return new SchoolManageDbContext(builder.Options);
        }
    }
}
