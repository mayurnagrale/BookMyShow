using static BookMyShow.Models.Enums;

namespace BookMyShow.Models
{
    public class SeatInShow : BaseModel
    {
        public SeatStatus seatStatus { get; set; }
        public Seat seat { get; set; }
        public Show1 show { get; set; }

        public Ticket ticket { get; set; }

        public DateTime LocketAt { get; set; }
    }
}
