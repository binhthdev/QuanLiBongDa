namespace DTO
{
    public class Team
    {
        public string TeamID { get; set; }
        public string TeamName { get; set; }
        public string Logo { get; set; }
        public DateTime FoundedYear { get; set; }
        public string Address { get; set; }     // Địa chỉ đội
        public string City { get; set; }        // Thành phố
        public string Nation { get; set; }      // Quốc gia
        public string Stadium { get; set; }     // Sân vận động
    }
}
