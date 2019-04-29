using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBanGiay.Data.EF.Extentions;
using ShopBanGiay.Data.Entities;

namespace ShopBanGiay.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
