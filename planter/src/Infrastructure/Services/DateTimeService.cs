using planter.Application.Common.Interfaces;

namespace planter.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
