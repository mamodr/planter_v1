using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using planter.Domain.Entities;

namespace planter.Infrastructure.Persistence.Configurations;
public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {

        builder.HasMany<Cart_Item>(x => x.Cart_Items).WithOne().HasForeignKey(x => x.Cart_ID);

    }
}
