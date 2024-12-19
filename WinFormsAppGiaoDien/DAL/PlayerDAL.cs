using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class PlayerDAL
    {
        private string connectionString = "Data Source=LAPTOP-7RFKE8GJ;Initial Catalog=FootballDB;User ID=sa;Password=123456;TrustServerCertificate=True";

        public bool InsertPlayer(PlayerDTO player)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Player (PlayerID, PlayerName, Age, Position, ShirtNumber, TeamID, Nationality, Image) " +
                               "VALUES (@PlayerID, @PlayerName, @Age, @Position, @ShirtNumber, @TeamID, @Nationality, @Image)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                cmd.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                cmd.Parameters.AddWithValue("@Age", player.Age);
                cmd.Parameters.AddWithValue("@Position", player.Position);
                cmd.Parameters.AddWithValue("@ShirtNumber", player.ShirtNumber);
                cmd.Parameters.AddWithValue("@TeamID", player.TeamID);
                cmd.Parameters.AddWithValue("@Nationality", player.Nationality);
                cmd.Parameters.AddWithValue("@Image", player.Image ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdatePlayer(PlayerDTO player)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Player SET ";
                List<string> setClauses = new List<string>();
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(player.PlayerName))
                {
                    setClauses.Add("PlayerName = @PlayerName");
                    parameters.Add(new SqlParameter("@PlayerName", player.PlayerName));
                }
                if (player.Age != DateTime.MinValue)
                {
                    setClauses.Add("Age = @Age");
                    parameters.Add(new SqlParameter("@Age", player.Age));
                }
                if (!string.IsNullOrEmpty(player.Position))
                {
                    setClauses.Add("Position = @Position");
                    parameters.Add(new SqlParameter("@Position", player.Position));
                }
                if (!string.IsNullOrEmpty(player.ShirtNumber))
                {
                    setClauses.Add("ShirtNumber = @ShirtNumber");
                    parameters.Add(new SqlParameter("@ShirtNumber", player.ShirtNumber));
                }
                if (!string.IsNullOrEmpty(player.TeamID))
                {
                    setClauses.Add("TeamID = @TeamID");
                    parameters.Add(new SqlParameter("@TeamID", player.TeamID));
                }
                if (!string.IsNullOrEmpty(player.Nationality))
                {
                    setClauses.Add("Nationality = @Nationality");
                    parameters.Add(new SqlParameter("@Nationality", player.Nationality));
                }
                if (!string.IsNullOrEmpty(player.Image))
                {
                    setClauses.Add("Image = @Image");
                    parameters.Add(new SqlParameter("@Image", player.Image));
                }

                if (setClauses.Count == 0)
                {
                    return false;
                }

                query += string.Join(", ", setClauses) + " WHERE PlayerID = @PlayerID";
                parameters.Add(new SqlParameter("@PlayerID", player.PlayerID));

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeletePlayer(string playerID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Player WHERE PlayerID = @PlayerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PlayerID", playerID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<PlayerDTO> GetAllPlayers()
        {
            List<PlayerDTO> players = new List<PlayerDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Player";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    players.Add(new PlayerDTO
                    {
                        PlayerID = reader["PlayerID"].ToString(),
                        PlayerName = reader["PlayerName"].ToString(),
                        Age = DateTime.Parse(reader["Age"].ToString()),
                        Position = reader["Position"].ToString(),
                        ShirtNumber = reader["ShirtNumber"].ToString(),
                        TeamID = reader["TeamID"].ToString(),
                        Nationality = reader["Nationality"].ToString(),
                        Image = reader["Image"]?.ToString() // Đọc trường Image
                    });
                }
            }
            return players;
        }

        public List<PlayerDTO> SearchPlayer(string keyword)
        {
            List<PlayerDTO> players = new List<PlayerDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Player WHERE PlayerName LIKE @Keyword OR Position LIKE @Keyword OR ShirtNumber LIKE @Keyword OR TeamID LIKE @Keyword OR Nationality LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PlayerDTO player = new PlayerDTO
                    {
                        PlayerID = reader["PlayerID"].ToString(),
                        PlayerName = reader["PlayerName"].ToString(),
                        Age = DateTime.Parse(reader["Age"].ToString()),
                        Position = reader["Position"].ToString(),
                        ShirtNumber = reader["ShirtNumber"].ToString(),
                        TeamID = reader["TeamID"].ToString(),
                        Nationality = reader["Nationality"].ToString(), // Đọc trường Quốc tịch trong tìm kiếm
                        Image = reader["Image"]?.ToString() // Đọc trường Image
                    };
                    players.Add(player);
                }
            }
            return players;
        }
    }
}
