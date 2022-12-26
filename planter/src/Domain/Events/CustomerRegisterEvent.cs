using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planter.Domain.Events;
public class CustomerRegisterEvent:BaseEvent
{
    public Guid Customer_ID { get; private set; }

    public CustomerRegisterEvent(Guid customer_id)
    {
        this.Customer_ID = customer_id; 
    }
}
