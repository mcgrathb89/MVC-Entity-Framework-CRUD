using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Context
{
    public class MVCContext: DbContext
    {
        public MVCContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
