using System.Data.SQLite;
using System;

public class DataBase{

	private string AppData;
	private string conn;

	public DataBase()
	{
		AppData = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\CarManager";
		conn = $"Data Source={AppData}\\db.db; Version=3;";
	}

	public void CreateDatabase()
	{
		Console.WriteLine(AppData);
		Console.WriteLine(conn);
		if(!Directory.Exists(AppData))
		{
			Directory.CreateDirectory(AppData);
		}
		using(SQLiteConnection connection = new SQLiteConnection(conn))
		{
			connection.Open();
			SQLiteCommand CreationQuery = new SQLiteCommand(Queries.creationQuery, connection);
			CreationQuery.ExecuteNonQuery();
		}
	}
}