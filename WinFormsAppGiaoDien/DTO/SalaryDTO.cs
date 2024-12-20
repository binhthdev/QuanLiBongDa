namespace DTO
{
    public class SalaryDTO
    {
        public int SalaryID { get; set; }
        public string PlayerID { get; set; }
        public string TeamID { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Allowance { get; set; }
        public DateTime SalaryDate { get; set; }
    }
}
