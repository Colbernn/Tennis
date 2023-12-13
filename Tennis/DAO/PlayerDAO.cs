using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Models;

namespace Tennis.DAO
{
	internal class PlayerDAO : DAO<Player>
	{
		public override bool Create(Player obj)
		{
			throw new NotImplementedException();
		}

		public override bool Delete(Player obj)
		{
			throw new NotImplementedException();
		}

		public override Player Find(int id)
		{
			Player player = null;
			try
			{
				using (SqlConnection connection = new SqlConnection(this.connectionString))
				{
					SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Player WHERE id_player = @id", connection);
					cmd.Parameters.AddWithValue("id", id);
					connection.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							player = new Player()
							{
								id = reader.GetInt32("id_player"),
								firstname = reader.GetString("firstname"),
								lastname = reader.GetString("lastname"),
								nationality = reader.GetString("nationality"),
								rank = reader.GetInt32("ranking"),
								gender = reader.GetString("gender")
							};
						}
					}
				}
			}
			catch (SqlException)
			{
				throw new Exception("an sql error occured!");
			}
			return player;
		}


		public override bool Update(Player obj)
		{
			throw new NotImplementedException();
		}
	}
}
