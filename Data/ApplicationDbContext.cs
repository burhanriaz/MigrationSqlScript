using Microsoft.EntityFrameworkCore;
using MigrationTask.Models;

namespace MigrationTask.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opption):base(opption)
        {

        }
        public DbSet<Student> student { get; set; }
    }
}
