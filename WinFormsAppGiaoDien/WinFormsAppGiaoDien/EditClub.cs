using BUS;
using DTO;

namespace WinFormsAppGiaoDien
{
    public partial class EditClub : Form
    {
        private TeamBUS teamBUS = new TeamBUS();

        public EditClub()
        {
            InitializeComponent();
            this.btnUpDate.Click += new EventHandler(this.btnUpDate_Click);
        }

        // Xử lý sự kiện khi nhấn nút "UpDate"
        private void btnUpDate_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string teamID = txtTeamID.Text.Trim();
            string teamName = txtTeamName.Text.Trim();
            string logo = pictureBox1.ImageLocation; // Nếu bạn muốn lấy đường dẫn hình ảnh từ PictureBox
            DateTime foundedYear = dateTimePicker1.Value;
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string nation = txtNation.Text.Trim();
            string stadium = txtStadium.Text.Trim();

            // Kiểm tra nếu TeamID là hợp lệ
            if (string.IsNullOrEmpty(teamID))
            {
                MessageBox.Show("TeamID không thể trống!");
                return;
            }

            // Tạo đối tượng Team với TeamID đã có
            Team team = new Team
            {
                TeamID = teamID
            };

            // Cập nhật các giá trị nếu người dùng nhập thông tin mới
            if (!string.IsNullOrEmpty(teamName))
                team.TeamName = teamName;

            if (!string.IsNullOrEmpty(logo))
                team.Logo = logo;

            if (foundedYear != null) // Kiểm tra năm thành lập nếu có thay đổi
                team.FoundedYear = foundedYear;

            if (!string.IsNullOrEmpty(address))
                team.Address = address;

            if (!string.IsNullOrEmpty(city))
                team.City = city;

            if (!string.IsNullOrEmpty(nation))
                team.Nation = nation;

            if (!string.IsNullOrEmpty(stadium))
                team.Stadium = stadium;

            // Gọi phương thức UpdateTeam từ BUS để cập nhật dữ liệu
            bool isUpdated = teamBUS.UpdateTeam(team);

            // Hiển thị thông báo kết quả
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật thông tin CLB thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại.");
            }
        }
    }
}
