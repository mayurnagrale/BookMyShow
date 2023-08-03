namespace BookMyShow.Models
{
    public class Ticket : BaseModel
    {
        public DateTime BookingTime { get; set; }

        public List<Payment> payments { get; set; }

        public List<SeatInShow> seats { get; set; }

        public User bookedBy { get; set; }
    }
}
