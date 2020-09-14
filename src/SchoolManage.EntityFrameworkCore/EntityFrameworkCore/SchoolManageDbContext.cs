using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SchoolManage.Authorization.Roles;
using SchoolManage.Authorization.Users;
using SchoolManage.MultiTenancy;
using SchoolManage.Books;

namespace SchoolManage.EntityFrameworkCore
{
    public class SchoolManageDbContext : AbpZeroDbContext<Tenant, Role, User, SchoolManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SchoolManageDbContext(DbContextOptions<SchoolManageDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
