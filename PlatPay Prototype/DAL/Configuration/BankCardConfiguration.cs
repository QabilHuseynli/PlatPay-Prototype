using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatPay_Prototype.Models;

namespace PlatPay_Prototype.DAL.Configuration
{
    public class BankCardConfiguration : IEntityTypeConfiguration<BankCard>
    {
        public void Configure(EntityTypeBuilder<BankCard> builder)
        {
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
        }
    }
}
