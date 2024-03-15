using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.Coin;
using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class CoinMapping : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder.ToTable("Coins");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Symbol).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Link).HasMaxLength(255).IsRequired();
            builder.Property(x => x.ImageAddress).HasMaxLength(255);

            builder.HasMany(x => x.CoinPrices)
                .WithOne(x => x.Coin)
                .HasForeignKey(x => x.CoinID);
        }
    }
}
