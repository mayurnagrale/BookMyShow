using static BookMyShow.Models.Enums;

namespace BookMyShow.Models
{
    public class Payment : BaseModel 
    {
        public int Amount { get; set; }
        public string TransactionId { get; set; }

        public PaymentStatus paymentStatus { get; set; }

        public PaymentProvider paymentProvider { get; set; }

        public Ticket ticket { get; set; }

    }
}
