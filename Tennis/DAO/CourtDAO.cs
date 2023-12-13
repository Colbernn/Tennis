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
	internal class CourtDAO : DAO<Court>
	{
		public override bool Create(Court obj)
		{
			throw new NotImplementedException();
		}

		public override bool Delete(Court obj)
		{
			throw new NotImplementedException();
		}

		public override Court Find(int id)
		{
			Court court = null;
			try
			{
				using (SqlConnection connection = new SqlConnection(this.connectionString))
				{
					SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Court WHERE id_court = @id", connection);
					cmd.Parameters.AddWithValue("id", id);
					connection.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							court = new Court()
							{
								id_court = reader.GetInt32("id_court"),
								nbSpectators = reader.GetInt32("nbSpectators"),
								covered = reader.GetBoolean("covered")
							};
						}
					}
				}
			}
			catch (SqlException)
			{
				throw new Exception("an sql error occured!");
			}
			return court;
		}

		public override bool Update(Court obj)
		{
			throw new NotImplementedException();
		}
	}
}
