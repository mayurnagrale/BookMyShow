using static BookMyShow.Models.Enums;

namespace BookMyShow.Models
{
    public class SeatTypeInShow : BaseModel
    {
        public int Price { get; set; }

        public SeatType seatType { get; set; }

        public Show1 show1 { get; set; }
    }
}
