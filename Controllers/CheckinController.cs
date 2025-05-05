class CheckinController
{
	private Database db = new Database();

	public CheckinController()
	{
		this.db = db;
	}

	public void AddCheckin(string id, string carId, int clientId, DateTime checkinDate, DateTime checkoutDate, string entranceState)
	{

	}

	public void EditCheckin(string? id, string? carId, int? clientId, DateTime? checkinDate, DateTime? checkoutDate, string? entranceState)
	{
		
	}

	public List<Checkin> GetCheckinList(string carPlates)
	{
		
	}

	public List<Checkin> GetActiveCheckinList()
	{
		
	}
}