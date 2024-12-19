using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class RefereeDAL
    {
        private string connectionString = "Data Source=LAPTOP-7RFKE8GJ;Initial Catalog=FootballDB;User ID=sa;Password=123456;TrustServerCertificate=True";

        public List<RefereeDTO> GetAllReferees()
        {
            List<RefereeDTO> referees = new List<RefereeDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Referee";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    referees.Add(new RefereeDTO
                    {
                        RefereeID = reader["RefereeID"].ToString(),
                        RefereeName = reader["RefereeName"].ToString(),
                        Nationality = reader["Nationality"].ToString(),
                        DateOfBirth = (DateTime)reader["DateOfBirth"]
                    });
                }
            }
            return referees;
        }

        public List<RefereeDTO> SearchReferees(string keyword)
        {
            List<RefereeDTO> referees = new List<RefereeDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Referee WHERE RefereeName LIKE @Keyword OR Nationality LIKE @Keyword";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    referees.Add(new RefereeDTO
                    {
                        RefereeID = reader["RefereeID"].ToString(),
                        RefereeName = reader["RefereeName"].ToString(),
                        Nationality = reader["Nationality"].ToString(),
                        DateOfBirth = (DateTime)reader["DateOfBirth"]
                    });
                }
            }
            return referees;
        }

        public bool AddReferee(RefereeDTO referee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Referee (RefereeID, RefereeName, Nationality, DateOfBirth) VALUES (@RefereeID, @RefereeName, @Nationality, @DateOfBirth)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RefereeID", referee.RefereeID);
                command.Parameters.AddWithValue("@RefereeName", referee.RefereeName);
                command.Parameters.AddWithValue("@Nationality", referee.Nationality);
                command.Parameters.AddWithValue("@DateOfBirth", referee.DateOfBirth);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
        }

        public bool UpdateReferee(RefereeDTO referee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Referee SET RefereeName = @RefereeName, Nationality = @Nationality, DateOfBirth = @DateOfBirth WHERE RefereeID = @RefereeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RefereeID", referee.RefereeID);
                command.Parameters.AddWithValue("@RefereeName", referee.RefereeName);
                command.Parameters.AddWithValue("@Nationality", referee.Nationality);
                command.Parameters.AddWithValue("@DateOfBirth", referee.DateOfBirth);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
        }

        public bool DeleteReferee(string refereeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Referee WHERE RefereeID = @RefereeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RefereeID", refereeID);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
