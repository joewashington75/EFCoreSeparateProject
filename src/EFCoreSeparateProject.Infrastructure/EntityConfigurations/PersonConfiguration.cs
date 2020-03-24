using EFCoreSeparateProject.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreSeparateProject.Infrastructure.EntityConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.OwnsOne(e => e.Address, t =>
            {
                //t.OwnsOne(a => a.Line1).Property(e => e.Line).HasColumnName("AddressLine1");
                t.OwnsOne(a => a.Line1);
                t.OwnsOne(a => a.Line2);
                t.OwnsOne(a => a.Postcode);
            });
        }
    }
}
