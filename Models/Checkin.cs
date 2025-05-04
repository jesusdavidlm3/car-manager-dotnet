namespace CarManager.Models
{
    public class Checkin
    {
        public string Id { get; private set; }
        public string CarId { get; set; }
        public int ClientId { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public string EntranceState { get ; set; }

        public Checkin(string id, string carId, int clientId, DateTime checkinDate, DateTime checkoutDate, string entranceState)
        {
            this.Id = id;
            this.CarId = carId;
            this.ClientId = clientId;
            this.CheckinDate = checkinDate;
            this.CheckoutDate = checkoutDate;
            this.EntranceState = entranceState;
        }

        public void CreateCheckin()
        {
            Console.WriteLine("Checkin Registrado");
        }

        public void CloseCheckin()
        {
            Console.WriteLine("Checkin cerrado");
        }
        
    }
}