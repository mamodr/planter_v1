using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using planter.Domain.Events;

namespace planter.Application.Order.EventHandlers;
internal class OrderMadeEventHandler : INotificationHandler<OrderMadeEvent>
{
    public Task Handle(OrderMadeEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
