namespace BookMyShow.Models
{
    public class Enums
    {
        public enum SeatType
        {
            SILVER,
            GOLD,
            PLATINUM
        }

        public enum Role
        {
            ADMIN,
            OWNER,
            CUSTOMER
        }

        public enum Feature
        {
            TWOD,
            THREED,
            DOLBY,
            ATMOS
        }

        public enum SeatStatus
        {
            UNDER_MAINTAINANCE,
            AVAILABLE,
            LOCKED,
            BOOKED
        }

        public enum PaymentProvider
        {
            STRIPE,
            RAZORPAY,
            GPAY,
            AMAZONPAY
        }

        public enum PaymentStatus
        {
            INPROGRESS,
            SUCCESS,
            FAILURE,
            CANCELLED
        }
    }
}
