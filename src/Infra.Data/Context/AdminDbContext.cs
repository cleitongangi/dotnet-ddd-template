using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class AdminDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }        
    }
}