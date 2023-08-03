using static BookMyShow.Models.Enums;

namespace BookMyShow.Models
{
    public class Show1 : BaseModel
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Auditorium auditorium { get; set; }

        //@ManyToOne
        public List<Feature> requiredFeature { get; set; }
    }
}
