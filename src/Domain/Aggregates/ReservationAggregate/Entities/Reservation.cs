namespace Domain.Aggregates.ReservationAggregate
{
    public class Reservation: BaseEntity, IAggregateRoot
    {
        public Guid IdEvent {  get; set; }
        public Guid IdSeat { get; set; }
        public Guid? IdUserAccount { get; set; }
        public string ReservationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now).ToString("dd-MM-yyyy");
        public string ReservationTime { get; set; } = DateTime.Now.ToString("HH:mm");

        public Reservation() : base() { }
        public Reservation(Guid idEvent, Guid idSeat, Guid? idUserAccount) : base()
        {
            IdEvent = idEvent;
            IdSeat = idSeat;
            IdUserAccount = idUserAccount;
        }
    }
}
