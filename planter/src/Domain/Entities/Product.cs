using System.ComponentModel.DataAnnotations;

namespace planter.Domain.Entities;

public class Product : BaseAuditableEntity,IAggregateRoot
{
   
    public Guid id { get;  set; }

    public string Name { get;  set; }

    public string Details { get;  set; }


    public int Price { get;  set; }

    public Product(Guid id, string name, string details, int price)
    {
        this.id = id;
        Name = name;
        Details = details;
        Price = price;
    }


}