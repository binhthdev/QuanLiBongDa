using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGiaoDien
{
    public partial class Player : Form
    {
        private PlayerBUS playerBUS = new PlayerBUS();
        public Player()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox1_Click;
            btnClub.Click += button2_Click;
            btnResult.Click += button4_Click;
            btnReferee.Click += button3_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;
            btnEdit.Click += BtnEdit_Click; // Thêm sự kiện nút "Edit"
            LoadTeamData();
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            LoadPositionData();
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnUpload.Click += new EventHandler(this.btnUpload_Click);
            this.Load += Player_Load;
            LoadNationalityData(); // Load danh sách quốc tịch
            this.searchPlayer.TextChanged += searchPlayer_TextChanged;  // Thêm sự kiện TextChanged cho TextBox tìm kiếm                                                                        // Thêm sự kiện cho nút Delete
            btnDelete.Click += btnDelete_Click;
            btnSalary.Click += buttonSalary_Click;
        }


        // Hàm hiển thị danh sách cầu thủ vào DataGridView
        private void DisplayPlayers(List<PlayerDTO> players)
        {
            dataGridView1.Rows.Clear();  // Xóa các dòng cũ

            foreach (var player in players)
            {
                var rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];
                row.Cells["PlayerID"].Value = player.PlayerID;
                row.Cells["PlayerName"].Value = player.PlayerName;
                row.Cells["Age"].Value = player.Age.ToString("yyyy-MM-dd");
                row.Cells["Position"].Value = player.Position;
                row.Cells["ShirtNumber"].Value = player.ShirtNumber;
                row.Cells["TeamID"].Value = player.TeamID;
                row.Cells["Nationality"].Value = player.Nationality;

                // Nạp ảnh từ đường dẫn hoặc byte array
                if (!string.IsNullOrEmpty(player.Image))
                {
                    row.Cells["PlayerImage"].Value = Image.FromFile(player.Image);
                }
                else
                {
                    row.Cells["PlayerImage"].Value = Properties.Resources.Culture; // Ảnh mặc định
                }
            }
        }

        // Hàm tải dữ liệu cầu thủ khi form được tải
        private void Player_Load(object sender, EventArgs e)
        {
            List<PlayerDTO> players = playerBUS.GetPlayers();
            DisplayPlayers(players);
        }

        // Hàm xử lý tìm kiếm cầu thủ khi thay đổi từ khóa
        private void searchPlayer_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchPlayer.Text.Trim();  // Lấy từ khóa tìm kiếm từ TextBox
            List<PlayerDTO> searchResults = playerBUS.SearchPlayers(keyword);  // Gọi phương thức tìm kiếm từ PlayerBUS
            DisplayPlayers(searchResults);  // Hiển thị kết quả tìm kiếm vào DataGridView
        }

        // Sự kiện xử lý khi bấm nút btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy PlayerID từ dòng đã chọn
                string playerID = dataGridView1.SelectedRows[0].Cells["PlayerID"].Value.ToString();

                // Gọi phương thức DeletePlayer từ PlayerBUS để xóa cầu thủ
                bool result = playerBUS.DeletePlayer(playerID);

                if (result)
                {
                    MessageBox.Show("Player deleted successfully.");
                    // Tải lại danh sách cầu thủ sau khi xóa
                    List<PlayerDTO> players = playerBUS.GetPlayers();
                    DisplayPlayers(players);
                }
                else
                {
                    MessageBox.Show("Failed to delete player.");
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.");
            }
        }


        private void LoadTeamData()
        {
            List<Team> teams = playerBUS.GetTeams();
            cbxteamID.DataSource = teams;
            cbxteamID.DisplayMember = "TeamID";
            cbxteamID.ValueMember = "TeamID";
        }

        private void LoadPositionData()
        {
            cbbRole.Items.Add("Goalkeeper");  // Thủ môn
            cbbRole.Items.Add("Right Back");  // Hậu vệ phải
            cbbRole.Items.Add("Left Back");   // Hậu vệ trái
            cbbRole.Items.Add("Center Back"); // Trung vệ
            cbbRole.Items.Add("Sweeper");     // Hậu vệ quét
            cbbRole.Items.Add("Right Midfielder");   // Tiền vệ phải
            cbbRole.Items.Add("Left Midfielder");    // Tiền vệ trái
            cbbRole.Items.Add("Central Midfielder"); // Tiền vệ trung tâm
            cbbRole.Items.Add("Defensive Midfielder"); // Tiền vệ phòng ngự
            cbbRole.Items.Add("Attacking Midfielder"); // Tiền vệ tấn công
            cbbRole.Items.Add("Right Wing");   // Tiền vệ cánh phải
            cbbRole.Items.Add("Left Wing");    // Tiền vệ cánh trái
            cbbRole.Items.Add("Forward");     // Tiền đạo
            cbbRole.Items.Add("Center Forward");  // Tiền đạo trung tâm
            cbbRole.Items.Add("Second Striker");  // Tiền đạo lùi
        }

        private void LoadNationalityData()
        {
            List<string> nationalities = new List<string>
            {
                "Vietnam", "USA", "England", "France", "Germany",
                "Brazil", "Argentina", "Spain", "Italy", "Japan", "South Korea"
            };

            cbxNationality.Items.AddRange(nationalities.ToArray());
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            PlayerDTO newPlayer = new PlayerDTO
            {
                PlayerID = txtPlayerID.Text,
                PlayerName = ttxNamePlayer.Text,
                Age = dateTimePickerPlayer.Value,
                Position = cbbRole.Text,
                ShirtNumber = txtNumberPlayer.Text,
                Nationality = cbxNationality.Text,
                TeamID = cbxteamID.SelectedValue.ToString(),
                Image = pictureBox2.ImageLocation
            };

            bool isAdded = playerBUS.AddPlayer(newPlayer);

            if (isAdded)
            {
                MessageBox.Show("Player added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayPlayers(playerBUS.GetPlayers()); // Tải lại danh sách cầu thủ
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtPlayerID.Clear();
            ttxNamePlayer.Clear();
            txtNumberPlayer.Clear();
            cbxNationality.SelectedIndex=-1;
            cbbRole.SelectedIndex = -1;
            cbxteamID.SelectedIndex = -1;
            pictureBox2.Image = null;
            dateTimePickerPlayer.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        // Hàm xử lý sự kiện khi nhấn nút Edit
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtPlayerID.Text) || string.IsNullOrWhiteSpace(ttxNamePlayer.Text))
            {
                MessageBox.Show("Player ID và Player Name không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các trường nhập liệu
            PlayerDTO updatedPlayer = new PlayerDTO
            {
                PlayerID = txtPlayerID.Text,
                PlayerName = ttxNamePlayer.Text,
                Age = dateTimePickerPlayer.Value,
                Position = cbbRole.Text,
                ShirtNumber = txtNumberPlayer.Text,
                Nationality = cbxNationality.Text,
                TeamID = cbxteamID.SelectedValue.ToString(),
                Image = pictureBox2.ImageLocation
            };

            // Gọi phương thức cập nhật từ PlayerBUS
            bool isUpdated = playerBUS.UpdatePlayer(updatedPlayer);

            if (isUpdated)
            {
                MessageBox.Show("Player updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                DisplayPlayers(playerBUS.GetPlayers()); // Tải lại danh sách cầu thủ
            }
            else
            {
                MessageBox.Show("Failed to update player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý sự kiện khi chọn một dòng trong DataGridView
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy dữ liệu từ hàng được chọn
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            txtPlayerID.Text = selectedRow.Cells["PlayerID"].Value?.ToString();
            ttxNamePlayer.Text = selectedRow.Cells["PlayerName"].Value?.ToString();

            // Kiểm tra và gán giá trị ngày sinh
            if (DateTime.TryParse(selectedRow.Cells["Age"].Value?.ToString(), out DateTime birthDate))
            {
                dateTimePickerPlayer.Value = birthDate;
            }

            cbbRole.Text = selectedRow.Cells["Position"].Value?.ToString();
            txtNumberPlayer.Text = selectedRow.Cells["ShirtNumber"].Value?.ToString();
            cbxNationality.Text = selectedRow.Cells["Nationality"].Value?.ToString();
            cbxteamID.SelectedValue = selectedRow.Cells["TeamID"].Value?.ToString();

            // Hiển thị ảnh (nếu có)
            if (selectedRow.Cells["PlayerImage"].Value is Image playerImage)
            {
                pictureBox2.Image = playerImage;
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        // Logic khi click vào pictureBox1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
        // Sự kiện xử lý khi bấm nút btnClub
        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Club
            Club club = new Club();

            // Hiển thị form Club
            club.Show();

            this.Close();
            this.Hide();

        }
        // Sự kiện xử lý khi bấm nút referee
        private void button3_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form referee
            Referee referee = new Referee();

            //Hiển thị form referee
            referee.Show();

            // Ẩn form MainForm 
            this.Hide();
        }

        // Sự kiện xử lý khi bấm nút result
        private void button4_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form result
            Result result = new Result();

            // Hiển thị form result
            result.Show();

            this.Close();
            this.Hide();
        }

        // Sự kiện xử lý khi bấm nút result
        private void buttonSalary_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form result
            Salary salary = new Salary();

            // Hiển thị form result
            salary.Show();

            //this.Close();
            //this.Hide();
        }
    }
}
