using Domain.Aggregates.SeatAggregate;

namespace Domain.Aggregates.EventAggregate
{
    public class Event : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public ICollection<Seat> Seats { get; set; } = new List<Seat>();

        private Event() : base() { }

        public Event(string name, string eventDate, string eventTime, int row, int column, float priceTicket) : base()
        {
            Name = name;
            EventDate = eventDate;
            EventTime = eventTime;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    Seats.Add(new Seat(i.ToString(), j.ToString(), priceTicket, false));
                }
            }
        }
    }
}

