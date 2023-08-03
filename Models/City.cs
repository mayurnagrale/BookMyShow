namespace BookMyShow.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }

        //@OneToMany (Mapped by city)
        public List<Theatre> Theatres { get; set; }
    }
}
