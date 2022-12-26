using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using planter.Domain.Entities;

namespace planter.Infrastructure.Persistence.Configurations;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {

        builder.HasMany<OrderItem>(x => x.Order_Items).WithOne().HasForeignKey(x => x.Order_ID);

    }
}
