using NHibernate.Mapping;

namespace BookMyShow.Models
{
    public class Auditorium : BaseModel
    {
        public string Name { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        //@ManyToOne
        public Theatre theatre { get; set; }

        //@OneToMany
        public List<Seat> seats { get; set; }

        //@OneToMany
        public Show1 show { get; set; }
    }
}
