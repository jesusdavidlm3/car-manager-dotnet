class RegEntryController
{

	private Database db = new Database();

	public RegEntryController(){
		this.db = db;
	}

	public void AddRegEntry(string id, int? quantity, string description, string checkinId, DateTime date)
	{

	}

	public List<RegEntry> GetRegEntryList(string CheckinId)
	{
		
	}
}