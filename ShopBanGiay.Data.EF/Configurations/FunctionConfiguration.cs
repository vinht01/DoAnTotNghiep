using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBanGiay.Data.EF.Extentions;
using ShopBanGiay.Data.Entities;

namespace ShopBanGiay.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).IsRequired()
                .HasMaxLength(128).IsUnicode(false);
            // etc.
        }
    }
}
