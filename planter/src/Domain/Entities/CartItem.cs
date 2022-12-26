using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planter.Domain.Common;

namespace planter.Domain.Entities;
public class CartItem:BaseAuditableEntity
{
    public Guid CartID { get; set; }
    public Guid ProductID { get; set; }

    public int Quantity { get; set; }

    public float ItemPrice { get; set; }
    public float TotalPrice { get; set; }

    public CartItem(Guid cartID, Guid productID, int quantity, float price)
    {
        CartID = cartID;
        ProductID = productID;
        Quantity = quantity;
        ItemPrice = price;
       CalculateTotalPrice();
    }

    public void CalculateTotalPrice()
    {
        TotalPrice= ItemPrice * Quantity;
    }

    public void ChangeQuantity(int NewQuantity) {

        this.Quantity = NewQuantity;
        CalculateTotalPrice();
    }
}
