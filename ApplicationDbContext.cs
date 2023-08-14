using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LabWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add more DbSet properties for other entity types if needed
    }
}
