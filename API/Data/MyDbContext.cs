using API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> context) : base(context){
        }
        public DbSet<Students> Students { get; set; }
    }
}