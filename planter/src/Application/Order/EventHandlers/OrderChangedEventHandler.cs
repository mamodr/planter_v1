using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using planter.Domain.Events;

namespace planter.Application.Order.EventHandlers;
public class OrderChangedEventHandler : INotificationHandler<OrderChangedEvent>
{
    public Task Handle(OrderChangedEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

