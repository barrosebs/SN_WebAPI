using Microsoft.EntityFrameworkCore;
using SN.Domain;

namespace SN.Repository
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Atleta> atletas { get; set; }
    }
}