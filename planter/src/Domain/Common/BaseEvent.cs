using MediatR;

namespace planter.Domain.Common;
public abstract class BaseEvent : INotification
{
    protected BaseEvent()
    {
        this.OccurredOn = DateTime.Now;
    }

    public DateTime OccurredOn { get; }
}
