using CSharpFunctionalExtensions;
using Domain.Aggregates.SeatAggregate;

namespace Domain.Aggregates.EventAggregate.Repositories
{
    public interface IEventRepository
    {
        public Task<Result> AddEvent(string name, string reservationDate, string reservationTime);
        public Task<Result> UpdateEvent(Guid idEvent, string newName, string newReservationDate, string newReservationTime);
        public Task<Result> DeleteEvent(Guid idEvent);
        public Task<Result> GetEventById(Guid idEvent);
        public Task<Result<Seat[,]>> GetSeatsByEventId(Guid idEvent);
        public Task<List<Event>> GetAllEventsEvents();
    }
}
