using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TeamDAL
    {
        private string connectionString = "Data Source=LAPTOP-7RFKE8GJ;Initial Catalog=FootballDB;User ID=sa;Password=123456;TrustServerCertificate=True";

        public bool InsertTeam(Team team)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Team (TeamID, TeamName, Logo, FoundedYear, Address, City, Nation, Stadium) VALUES (@TeamID, @TeamName, @Logo, @FoundedYear, @Address, @City, @Nation, @Stadium)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeamID", team.TeamID);
                cmd.Parameters.AddWithValue("@TeamName", team.TeamName);
                cmd.Parameters.AddWithValue("@Logo", team.Logo);
                cmd.Parameters.AddWithValue("@FoundedYear", team.FoundedYear);
                cmd.Parameters.AddWithValue("@Address", team.Address);
                cmd.Parameters.AddWithValue("@City", team.City);
                cmd.Parameters.AddWithValue("@Nation", team.Nation);
                cmd.Parameters.AddWithValue("@Stadium", team.Stadium);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool UpdateTeam(Team team)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Xây dựng câu truy vấn cơ sở
                string query = "UPDATE Team SET ";

                // Danh sách tham số để thêm vào câu lệnh SQL
                List<SqlParameter> parameters = new List<SqlParameter>();

                // Kiểm tra từng trường, nếu có giá trị mới thì thêm vào câu lệnh SQL
                if (!string.IsNullOrEmpty(team.TeamName))
                {
                    query += "TeamName = @TeamName, ";
                    parameters.Add(new SqlParameter("@TeamName", team.TeamName));
                }

                if (!string.IsNullOrEmpty(team.Logo))
                {
                    query += "Logo = @Logo, ";
                    parameters.Add(new SqlParameter("@Logo", team.Logo));
                }

                if (team.FoundedYear != default(DateTime)) // Kiểm tra nếu là giá trị mặc định
                {
                    query += "FoundedYear = @FoundedYear, ";
                    parameters.Add(new SqlParameter("@FoundedYear", team.FoundedYear));
                }

                if (!string.IsNullOrEmpty(team.Address))
                {
                    query += "Address = @Address, ";
                    parameters.Add(new SqlParameter("@Address", team.Address));
                }

                if (!string.IsNullOrEmpty(team.City))
                {
                    query += "City = @City, ";
                    parameters.Add(new SqlParameter("@City", team.City));
                }

                if (!string.IsNullOrEmpty(team.Nation))
                {
                    query += "Nation = @Nation, ";
                    parameters.Add(new SqlParameter("@Nation", team.Nation));
                }

                if (!string.IsNullOrEmpty(team.Stadium))
                {
                    query += "Stadium = @Stadium, ";
                    parameters.Add(new SqlParameter("@Stadium", team.Stadium));
                }

                // Xóa dấu phẩy cuối cùng nếu có trường hợp không cập nhật gì
                if (query.EndsWith(", "))
                {
                    query = query.Substring(0, query.Length - 2);
                }

                // Thêm điều kiện WHERE để xác định bản ghi cần cập nhật
                query += " WHERE TeamID = @TeamID";
                parameters.Add(new SqlParameter("@TeamID", team.TeamID));

                // Thực thi câu truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }



        public bool DeleteTeam(string teamID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Team WHERE TeamID = @TeamID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeamID", teamID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public List<Team> GetAllTeams()
        {
            List<Team> teams = new List<Team>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Team";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Team team = new Team
                    {
                        TeamID = reader["TeamID"].ToString(),
                        TeamName = reader["TeamName"].ToString(),
                        Logo = reader["Logo"].ToString(),
                        FoundedYear = (DateTime)reader["FoundedYear"],
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        Nation = reader["Nation"].ToString(),
                        Stadium = reader["Stadium"].ToString()
                    };
                    teams.Add(team);
                }
            }
            return teams;
        }

        public List<Team> SearchTeams(string keyword)
        {
            List<Team> teams = new List<Team>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Team WHERE TeamName LIKE @Keyword OR TeamID LIKE @Keyword OR FoundedYear LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Team team = new Team
                    {
                        TeamID = reader["TeamID"].ToString(),
                        TeamName = reader["TeamName"].ToString(),
                        Logo = reader["Logo"].ToString(),
                        FoundedYear = (DateTime)reader["FoundedYear"],
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        Nation = reader["Nation"].ToString(),
                        Stadium = reader["Stadium"].ToString()
                    };
                    teams.Add(team);
                }
            }
            return teams;
        }
    }
}
