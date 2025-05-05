class ClientController
{
	private Database db = new Database();

	public ClientController(){
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

	public Client GetClientById(string ClientId)
	{

	}

	public List<Client> GetClientListByName(string param)
	{

	}

	public Client GetClient(string ClientId)
	{

	}
}