using System.Data.SQLite;
using System;

public class Database{

	private string AppData;
	private string conn;

	public Database()
	{
		this.AppData = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\CarManager";
		this.conn = $"Data Source={AppData}\\db.db; Version=3;";
	}

	public void CreateDatabase()
	{
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