using CarManager.Models;

class ClientController
{
	private Database db = new Database();

	public ClientController(Database db){
		this.db = db;
	}

	public void AddClient(int id, string name, string lastname, string phone, string address)
	{

	}

	public void EditClient(int? id, string? name, string? lastname, string? phone, string? address)
	{

	}

	public List<Client> GetClientList()
	{

	}

	public List<Client> GetClientListByName(string param)
	{

	}

	public Client GetClient(string ClientId)
	{

	}
}