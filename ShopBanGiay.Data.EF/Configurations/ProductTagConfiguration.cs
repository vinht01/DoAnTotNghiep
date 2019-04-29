using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBanGiay.Data.EF.Extentions;
using ShopBanGiay.Data.Entities;

namespace ShopBanGiay.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
                .HasMaxLength(50).IsUnicode(false);
            // etc.
        }
    }
}
