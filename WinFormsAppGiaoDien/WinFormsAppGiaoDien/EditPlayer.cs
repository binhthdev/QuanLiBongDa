using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGiaoDien
{
    public partial class EditPlayer : Form
    {
        private PlayerBUS playerBUS = new PlayerBUS();

        public EditPlayer()
        {
            InitializeComponent();
            LoadTeams();
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            this.btnUpload.Click += new EventHandler(this.btnUpload_Click);
            LoadPositionData(); // Tải dữ liệu vai trò vào ComboBox
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            // Tải danh sách đội bóng vào ComboBox
            LoadTeams();

        }

        // Hàm để tải danh sách đội bóng vào ComboBox
        private void LoadTeams()
        {
            var teams = playerBUS.GetTeams();
            cbxteamID.DataSource = teams;
            cbxteamID.DisplayMember = "TeamName";  // Tên đội bóng
            cbxteamID.ValueMember = "TeamID";  // ID của đội bóng
        }

        // Hàm để tải dữ liệu vai trò cầu thủ vào ComboBox
        private void LoadPositionData()
        {
            // Thêm các vai trò vào ComboBox
            cbxRole.Items.Add("Goalkeeper");  // Thủ môn
            cbxRole.Items.Add("Right Back");  // Hậu vệ phải
            cbxRole.Items.Add("Left Back");   // Hậu vệ trái
            cbxRole.Items.Add("Center Back"); // Trung vệ
            cbxRole.Items.Add("Sweeper");     // Hậu vệ quét
            cbxRole.Items.Add("Right Midfielder");   // Tiền vệ phải
            cbxRole.Items.Add("Left Midfielder");    // Tiền vệ trái
            cbxRole.Items.Add("Central Midfielder"); // Tiền vệ trung tâm
            cbxRole.Items.Add("Defensive Midfielder"); // Tiền vệ phòng ngự
            cbxRole.Items.Add("Attacking Midfielder"); // Tiền vệ tấn công
            cbxRole.Items.Add("Right Wing");   // Tiền vệ cánh phải
            cbxRole.Items.Add("Left Wing");    // Tiền vệ cánh trái
            cbxRole.Items.Add("Forward");     // Tiền đạo
            cbxRole.Items.Add("Center Forward");  // Tiền đạo trung tâm
            cbxRole.Items.Add("Second Striker");  // Tiền đạo lùi
        }

        // Hàm cập nhật thông tin cầu thủ
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và ComboBox
            string playerID = txtPlayerID.Text.Trim();
            string playerName = ttxNamePlayer.Text.Trim();
            string shirtNumber = txtNumberPlayer.Text.Trim();
            string nationality = txtNationality.Text.Trim();
            string position = cbxRole.Text.Trim();
            string teamID = cbxteamID.SelectedValue.ToString();
            DateTime birthDate = dateTimePickerPlayer.Value;

            // Kiểm tra nếu PlayerID là hợp lệ
            if (string.IsNullOrEmpty(playerID))
            {
                MessageBox.Show("PlayerID không thể trống!");
                return;
            }

            // Tạo đối tượng PlayerDTO với PlayerID đã có
            PlayerDTO player = new PlayerDTO
            {
                PlayerID = playerID
            };

            // Cập nhật các giá trị nếu người dùng nhập thông tin mới
            if (!string.IsNullOrEmpty(playerName))
                player.PlayerName = playerName;

            if (!string.IsNullOrEmpty(shirtNumber))
                player.ShirtNumber = shirtNumber;

            if (!string.IsNullOrEmpty(nationality))
                player.Nationality = nationality;

            if (!string.IsNullOrEmpty(position))
                player.Position = position;

            if (cbxteamID.SelectedIndex != -1)
                player.TeamID = teamID;

            if (birthDate != DateTime.MinValue) // Kiểm tra ngày sinh nếu có thay đổi
                player.Age = birthDate;

            if (pictureBox1.Image != null) // Kiểm tra nếu có ảnh mới
                player.Image = ConvertImageToBase64(pictureBox1.Image);

            // Gọi phương thức UpdatePlayer từ PlayerBUS để cập nhật dữ liệu
            bool result = playerBUS.UpdatePlayer(player);

            // Hiển thị thông báo kết quả
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin cầu thủ thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại.");
            }
        }


        // Hàm để chuyển đổi ảnh thành base64 (nếu có)
        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] byteArray = ms.ToArray();
                return Convert.ToBase64String(byteArray);
            }
        }

        // Khi nhấn nút Upload, bạn có thể tải ảnh lên (ví dụ: sử dụng OpenFileDialog)
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // Khi nhấn nút Clear, sẽ làm sạch các trường
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlayerID.Clear();
            ttxNamePlayer.Clear();
            txtNumberPlayer.Clear();
            txtNationality.Clear();
            cbxRole.SelectedIndex = -1;
            cbxteamID.SelectedIndex = -1;
            dateTimePickerPlayer.Value = DateTime.Now;
            pictureBox1.Image = null;
        }
    }
}
