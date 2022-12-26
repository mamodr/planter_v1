using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planter.Domain.Entities;
public class Order : BaseAuditableEntity,IAggregateRoot
{
    public Guid Customer_ID { get; set; }

    public Guid Order_ID { get; set; }

    public DateTime place_time { get; set; }

    public OrderStatus status { get; set; }

    public float TotalPrice { get; set; }



    private ICollection<OrderItem> Order_Items;

    public Order(Guid customer_ID, ICollection<OrderItem> order_Items)
    {
        Customer_ID = customer_ID;
        Order_ID = Guid.NewGuid();
        this.place_time = DateTime.Now;
        status = OrderStatus.Placed;
        Order_Items = order_Items;
        TotalPrice = 0;
    }


    public void Calculate_TotalPrice() {

        TotalPrice = 0;
        foreach (OrderItem order_Item in Order_Items) {
            TotalPrice += order_Item.TotalPrice;
        }

    }


    
    public void Change(ICollection<OrderItem> NewOrder_Items)
    {



        foreach (OrderItem Item in NewOrder_Items)
        {

            var Cur_Item = Order_Items.SingleOrDefault(I => I.Product_ID == Item.Product_ID);

            if (Cur_Item == null)
            {

                Order_Items.Add(Item);
            }
            else
            {



            }

        }

        foreach (OrderItem Item in Order_Items)
        {

            OrderItem? Cur_Item = NewOrder_Items.SingleOrDefault(I => I.Product_ID == Item.Product_ID);

            if (Cur_Item == null)
            {
            
                Order_Items.Remove(Item);
                
            }

            Calculate_TotalPrice();
        }
    }
    
}