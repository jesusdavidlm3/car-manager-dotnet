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

	public void CreateClient(int id, string name, string lastname, string phone, string address)
	{
		using(SQLiteConnection connection = new SQLiteConnection(conn))
		{
			connection.Open();
			using(SQLiteCommand CreationQuery = new SQLiteCommand(Queries.registerClient, connection);)
			{
				CreationQuery.Parameters.AddWithValue("@id", id);
				CreationQuery.Parameters.AddWithValue("@name", name);
				CreationQuery.Parameters.AddWithValue("@lastname", lastname);
				CreationQuery.Parameters.AddWithValue("@phone", phone);
				CreationQuery.Parameters.AddWithValue("@address", address);
				CreationQuery.ExecuteNonQuery();
			}
		}
	}

	public void EditClient(int id, string? name, string? lastname, string? phone, string? address)
	{
		using(SQLiteConnection connection = new SQLiteConnection(conn))
		{
			connection.Open();
			using(SQLiteCommand query = new SQLiteCommand(Queries.EditClient))
			{
				query.Parameters.AddWithValue("@id", id);
				if(name)
				{
					query.Parameters.AddWithValue("@name", name);
				}
				if(lastname)
				{
					query.Parameters.AddWithValue("@lastname", lastname);
				}
				if(phone)
				{
					query.Parameters.AddWithValue("@phone", phone);
				}
				if(address)
				{
					query.Parameters.AddWithValue("@address", address);
				}
				query.ExecuteNonQuery();
			}
		}
	}
}