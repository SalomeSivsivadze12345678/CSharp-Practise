namespace Practice
{
    public class HotelBooking
    {
        public string GuestName { get; private set; }
        public int RoomNumber { get; private set; }
        public int PricePerNight { get; private set; }


        public HotelBooking(string guestName, int roomNumber, int pricePerNight)
        {
            GuestName = guestName;

            if (roomNumber <= 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                RoomNumber = roomNumber;
            }
            if (pricePerNight <= 0)
            {
                Console.WriteLine("enter correct number");
            }
            else
            {
                PricePerNight = pricePerNight;
            }

        }

        public int CalculateTotalPrice(int amountOfNights)

        {
            return PricePerNight * amountOfNights;
        }

        public void PrintBookingDetails(int totalPrice)
        {
            Console.WriteLine($"Name: {GuestName}, room number: {RoomNumber}, total price: {totalPrice} ");
        }

        public void ValidateAmountOfNights(int amountOfNights)
        {
            if (amountOfNights <= 0)
            {
                Console.WriteLine("write Correct number");
            }
        }
    }

}
