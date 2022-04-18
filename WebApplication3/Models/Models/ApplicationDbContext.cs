using Microsoft.EntityFrameworkCore;
namespace CrudEntity.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }
        public DbSet<Students> Students { get; set; }
        public DbSet<Std_Gender> Gender { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<States>States { get; set; }
        public DbSet<Cities>Cities{ get; set; }


    }
}
