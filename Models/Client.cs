namespace CarManager.Models
{
    public class Client
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Client(int id, string name, string lastname, string phone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.Phone = phone;
            this.Address = address;
        }
    }
}