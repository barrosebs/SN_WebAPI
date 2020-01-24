using Microsoft.EntityFrameworkCore;
using SN.WebAPI.Model;

namespace SN.WebAPI.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Atleta> atletas { get; set; }
    }
}