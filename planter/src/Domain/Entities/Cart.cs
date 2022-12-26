using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace planter.Domain.Entities;
public class Cart : BaseAuditableEntity ,IAggregateRoot
{
    public Guid Customer_ID { get; set; }

    private readonly ICollection<CartItem> CartItems;



    public Cart(Guid customer_ID)
    {
        Customer_ID = customer_ID;
        this.CartItems = new List<CartItem>();


    }


    public void DeleteItem(Guid ProductID) {
        var Item = CartItems.Single(I => I.ProductID == ProductID);
        CartItems.Remove(Item);

    }
    public void AddItem(CartItem Item)
    {
        CartItems.Add(Item);
    }

    public void ClearCart()
    {
        CartItems.Clear();
    }
    public void EditItemQuantity(Guid ProductID,int NewQuantity)
    {

        var Item = CartItems.Single(I => I.ProductID == ProductID);
        Item.ChangeQuantity(NewQuantity);
    }
}
