using CarManager.Models;

class CarController
{

	private Database db = new Database();

	public CarController(Database db){
		this.db = db;
	}

	public void AddCar(string id, string plates, int brandId, int modelId, string Color, int year)
	{

	}

	public void EditCar(string? id, string? plates, int? brandId, int? modelId, string? Color, int? year )
	{

	}

	public List<Checkin> GetCar(string carPlates)
	{

	}
}