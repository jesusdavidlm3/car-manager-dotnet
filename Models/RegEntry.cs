namespace CarManager.Models
{
	public class RegEntry
	{
		public string Id { get; private set; } 
		public int? Quantity { get; set; }
		public string Description { get; set; }
		public string CheckinId { get; }
		public DateTime Date { get; set; }

		public RegEntry(string id, int? quantity, string description, string checkinId, DateTime date){
			this.Id = id;
			this.Quantity = quantity;
			this.Description = description;
			this.CheckinId = checkinId;
			this.Date = date;
		}
	}
}