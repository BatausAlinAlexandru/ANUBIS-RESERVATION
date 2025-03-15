 namespace Domain.Aggregates.SeatAggregate
{
    public class Seat: BaseEntity, IAggregateRoot
    {
        public string Row { get; set; }
        public string Column { get; set; }
        public float Price { get; set; }
        public bool IsReservated { get; set; } = false;

        public Seat(string row, string column, float price, bool isReservated) : base()
        {
            Row = row;
            Column = column;
            Price = price;
            IsReservated = isReservated;
        }
    }
}
