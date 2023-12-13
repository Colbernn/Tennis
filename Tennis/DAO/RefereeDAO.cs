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
	internal class RefereeDAO : DAO<Referee>
	{
		public override bool Create(Referee obj)
		{
			throw new NotImplementedException();
		}

		public override bool Delete(Referee obj)
		{
			throw new NotImplementedException();
		}

		public override Referee Find(int id)
		{
			Referee referee = null;
			try
			{
				using (SqlConnection connection = new SqlConnection(this.connectionString))
				{
					SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Player WHERE id_referee = @id", connection);
					cmd.Parameters.AddWithValue("id", id);
					connection.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							referee = new Referee()
							{
								id = reader.GetInt32("id_referee"),
								firstname = reader.GetString("firstname"),
								lastname = reader.GetString("lastname"),
								nationality = reader.GetString("nationality")
							};
						}
					}
				}
			}
			catch (SqlException)
			{
				throw new Exception("an sql error occured!");
			}
			return referee;
		}

		public override bool Update(Referee obj)
		{
			throw new NotImplementedException();
		}
	}
}
