namespace DTO
{
    public class SalaryDetailsDTO
    {
        public int SalaryID { get; set; }
        public string PlayerName { get; set; }
        public string Position { get; set; }
        public string ShirtNumber { get; set; }
        public string Nationality { get; set; }
        public string TeamName { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Allowance { get; set; }
        public DateTime SalaryDate { get; set; }
    }
}
