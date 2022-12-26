using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using planter.Domain.Events;

namespace planter.Application.Customer.EventHandlers;
public class CustomerRegisterEventHandlercs : INotificationHandler<CustomerRegisterEvent>
{
    public Task Handle(CustomerRegisterEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
