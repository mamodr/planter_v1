using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planter.Domain.Events;
public class OrderChangedEvent : BaseEvent
{
    public Guid Order_ID { get;  }

    public OrderChangedEvent(Guid order_ID)
    {
        Order_ID = order_ID;
    }
}
