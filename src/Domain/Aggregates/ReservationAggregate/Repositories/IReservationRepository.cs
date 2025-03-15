using CSharpFunctionalExtensions;

namespace Domain.Aggregates.ReservationAggregate.Repositories
{
    public interface IReservationRepository
    {
        public Task<Result> AddReservationAsync(Guid idEvent, Guid idSeat, Guid idUserAccount);
        public Task<Result> UpdateReservationAsync(Guid idReservation, Guid newIdEvent, Guid newIdSeat, Guid newIdUserAccount);
        public Task<Result> DeleteReservationAsync(Guid idReservation);
        public Task<Result> GetReservationByIdAsync(Guid idReservation);
        public Task<List<Reservation>> GetAllReservationListAsync();
    }
}
