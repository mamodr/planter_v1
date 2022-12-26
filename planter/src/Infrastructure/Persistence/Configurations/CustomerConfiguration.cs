using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using planter.Domain.Entities;

namespace planter.Infrastructure.Persistence.Configurations;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {



        builder.HasOne(x=>x.cart).WithOne().HasForeignKey<Cart>(x=>x.Customer_ID);


        builder.HasMany<Order>(x => x.Orders).WithOne().HasForeignKey(x => x.Customer_ID);


    }
}
