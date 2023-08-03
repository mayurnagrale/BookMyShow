namespace BookMyShow.Models
{
    public class Theatre : BaseModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int MaxSeatsBookingAllowed { get; set; }

        //@ManyToOne
        public City city { get; set; }

        //Theatre to Auditorium relationship
        //OneToMany relationship
        public List<Auditorium> auditoriums { get; set; }
    }
}
