using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBanGiay.Data.EF.Extentions;
using ShopBanGiay.Data.Entities;

namespace ShopBanGiay.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                .IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}
