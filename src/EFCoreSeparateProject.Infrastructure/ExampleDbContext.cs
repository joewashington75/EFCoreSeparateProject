using EFCoreSeparateProject.Core.Domain;
using EFCoreSeparateProject.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSeparateProject.Infrastructure
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public ExampleDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PersonConfiguration());
        }
    }
}
