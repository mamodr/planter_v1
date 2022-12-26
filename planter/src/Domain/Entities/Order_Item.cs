using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planter.Domain.Entities;
public class OrderItem
{


    public Guid OrderID { get; set; }
    public Guid Product_ID { get; set; }

    

    public int Quantity { get; set; }

    public float TotalPrice { get; set; }

    public OrderItem(Guid orderID, Guid product_ID, int quantity, float totalPrice)
    {
        OrderID = orderID;
        Product_ID = product_ID;
        Quantity = quantity;
        TotalPrice = totalPrice;
    }
}
