using MediatR;
using Microsoft.Extensions.Logging;
using planter.Domain.Events;

namespace planter.Application.TodoItems.EventHandlers;
public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("planter Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
