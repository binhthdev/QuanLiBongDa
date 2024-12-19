namespace DTO
{
    public class PlayerDTO
    {
        public string PlayerID { get; set; }
        public string PlayerName { get; set; }
        public DateTime Age { get; set; }
        public string Position { get; set; }
        public string ShirtNumber { get; set; }
        public string TeamID { get; set; }
        public string Nationality { get; set; }  // Thêm trường Quốc tịch
        public string Image { get; set; }
    }
}
