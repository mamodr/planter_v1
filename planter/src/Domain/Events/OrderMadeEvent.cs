using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planter.Domain.Events;
public class OrderMadeEvent : BaseEvent
{

    public Guid Order_ID { get; }
    public Guid Customer_ID { get; }

    public float TotalPrice { get; }

    public OrderMadeEvent(Guid order_ID, Guid customer_ID, float totalPrice)
    {
        Order_ID = order_ID;
        Customer_ID = customer_ID;
        TotalPrice = totalPrice;
    }
}
