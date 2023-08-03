using static BookMyShow.Models.Enums;

namespace BookMyShow.Models
{
    public class Seat : BaseModel
    {
        public string Number { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public Auditorium auditorium { get; set; }

        
        public List<Feature> supportedFeature { get; set; }

        public SeatType seatType { get; set; }
    }
}
