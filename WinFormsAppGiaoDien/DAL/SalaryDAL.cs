using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class SalaryDAL
    {
        private string connectionString = "Data Source=LAPTOP-7RFKE8GJ;Initial Catalog=FootballDB;User ID=sa;Password=123456;TrustServerCertificate=True";

        public List<SalaryDetailsDTO> GetSalaryDetails()
        {
            var salaryDetailsList = new List<SalaryDetailsDTO>();

            string query = @"
                SELECT 
                    s.SalaryID,
                    p.PlayerName,
                    p.Position,
                    p.ShirtNumber,
                    p.Nationality,
                    t.TeamName,
                    s.MonthlySalary,
                    s.Bonus,
                    s.Allowance,
                    s.SalaryDate
                FROM Salary s
                JOIN Player p ON s.PlayerID = p.PlayerID
                JOIN Team t ON s.TeamID = t.TeamID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var salaryDetails = new SalaryDetailsDTO
                        {
                            SalaryID = reader.GetInt32(0),
                            PlayerName = reader.GetString(1),
                            Position = reader.GetString(2),
                            ShirtNumber = reader.GetString(3),
                            Nationality = reader.GetString(4),
                            TeamName = reader.GetString(5),
                            MonthlySalary = reader.GetDecimal(6),
                            Bonus = reader.GetDecimal(7),
                            Allowance = reader.GetDecimal(8),
                            SalaryDate = reader.GetDateTime(9)
                        };
                        salaryDetailsList.Add(salaryDetails);
                    }
                }
            }

            return salaryDetailsList;
        }

        // Thêm mới bản ghi Salary
        // Thêm lương mới
        public void AddSalary(SalaryDTO salary)
        {
            string query = @"
                INSERT INTO Salary (PlayerID, TeamID, MonthlySalary, Bonus, Allowance, SalaryDate)
                VALUES (@PlayerID, @TeamID, @MonthlySalary, @Bonus, @Allowance, @SalaryDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PlayerID", salary.PlayerID);
                cmd.Parameters.AddWithValue("@TeamID", salary.TeamID);
                cmd.Parameters.AddWithValue("@MonthlySalary", salary.MonthlySalary);
                cmd.Parameters.AddWithValue("@Bonus", salary.Bonus);
                cmd.Parameters.AddWithValue("@Allowance", salary.Allowance);
                cmd.Parameters.AddWithValue("@SalaryDate", salary.SalaryDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Sửa thông tin lương
        public void UpdateSalary(SalaryDTO salary)
        {
            string query = @"
                UPDATE Salary
                SET PlayerID = @PlayerID,
                    TeamID = @TeamID,
                    MonthlySalary = @MonthlySalary,
                    Bonus = @Bonus,
                    Allowance = @Allowance,
                    SalaryDate = @SalaryDate
                WHERE SalaryID = @SalaryID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalaryID", salary.SalaryID);
                cmd.Parameters.AddWithValue("@PlayerID", salary.PlayerID);
                cmd.Parameters.AddWithValue("@TeamID", salary.TeamID);
                cmd.Parameters.AddWithValue("@MonthlySalary", salary.MonthlySalary);
                cmd.Parameters.AddWithValue("@Bonus", salary.Bonus);
                cmd.Parameters.AddWithValue("@Allowance", salary.Allowance);
                cmd.Parameters.AddWithValue("@SalaryDate", salary.SalaryDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa thông tin lương
        public void DeleteSalary(int salaryID)
        {
            string query = "DELETE FROM Salary WHERE SalaryID = @SalaryID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalaryID", salaryID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Lấy danh sách Player
        public List<string> GetPlayerList()
        {
            var playerList = new List<string>();
            string query = "SELECT PlayerID FROM Player";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        playerList.Add(reader.GetString(0));
                    }
                }
            }
            return playerList;
        }

        // Lấy danh sách Team
        public List<string> GetTeamList()
        {
            var teamList = new List<string>();
            string query = "SELECT TeamID FROM Team";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teamList.Add(reader.GetString(0));
                    }
                }
            }
            return teamList;
        }
    }
}
