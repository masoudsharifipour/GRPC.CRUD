using Microsoft.EntityFrameworkCore;

namespace GrpcService_Crud.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}