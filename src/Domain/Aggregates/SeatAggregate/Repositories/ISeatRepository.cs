using CSharpFunctionalExtensions;

namespace Domain.Aggregates.SeatAggregate.Repositories
{
    public interface ISeatRepository
    {
        public Task<Result> GenerateSeatsAsync(Guid idEvent, int row, int column, float price);
        public Task<Result> UpdateSeatAsync(Guid idEvent, Guid idSeat, float newPrice, bool isReserved);
        public Task<Result> DeleteSeatAsync(Guid idEvent, Guid idSeat);
        public Task<Result> GetSeatByIdAsync(Guid idSeat);
        public Task<List<Seat>> GetAllSeatsAsync();
    }
}
