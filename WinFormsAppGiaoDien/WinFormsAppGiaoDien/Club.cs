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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsAppGiaoDien
{
    public partial class Club : Form
    {
        private TeamBUS teamBUS = new TeamBUS();
        public Club()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox1_Click;
            btnPlayer.Click += button2_Click;
            btnResult.Click += button4_Click;
            btnReferee.Click += button3_Click;
            btnAdd.Click += btnAdd_Click;
            btnClear.Click += btnClear_Click;
            btnUploadLogo.Click += btnUploadLogo_Click;
            this.Load += Form2_Load; // Đảm bảo sự kiện Load được liên kết
            this.searchTeams.TextChanged += searchTeams_TextChanged; // Liên kết sự kiện TextChanged
            this.btnDelete.Click += btnDelete_Click;
            dataGridViewTeams.CellClick += DataGridViewTeams_CellClick;
            btnEdit.Click += BtnEdit_Click;
        }

        // hiển thị dữ liệu
        // Hiển thị tất cả các đội trong DataGridView
        private void LoadAllTeams()
        {
            try
            {

                var teams = teamBUS.GetTeams();
                if (teams != null && teams.Count > 0)
                {
                    dataGridViewTeams.Rows.Clear(); // Xóa dữ liệu cũ
                    foreach (var team in teams)
                    {
                        Image logo = null;

                        // Nếu logo là một đường dẫn hoặc mảng byte, xử lý tại đây
                        if (!string.IsNullOrEmpty(team.Logo) && File.Exists(team.Logo))
                        {
                            logo = Image.FromFile(team.Logo);
                        }

                        dataGridViewTeams.Rows.Add(team.TeamID, team.TeamName, team.FoundedYear.ToString("yyyy"), team.Address, logo, team.Stadium, team.City, team.Nation);
                    }
                }
                else
                {
                    MessageBox.Show("No teams found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tìm kiếm đội theo từ khóa
        private void SearchTeams()
        {
            try
            {
                string keyword = searchTeams.Text.Trim();
                var teams = string.IsNullOrWhiteSpace(keyword)
                    ? teamBUS.GetTeams() // Nếu trống, tải tất cả đội
                    : teamBUS.SearchTeams(keyword); // Ngược lại, tìm kiếm với từ khóa

                dataGridViewTeams.Rows.Clear(); // Xóa dữ liệu cũ
                if (teams != null && teams.Count > 0)
                {
                    foreach (var team in teams)
                    {
                        Image logo = null;

                        // Nếu logo là một đường dẫn hoặc mảng byte, xử lý tại đây
                        if (!string.IsNullOrEmpty(team.Logo) && File.Exists(team.Logo))
                        {
                            logo = Image.FromFile(team.Logo);
                        }

                        dataGridViewTeams.Rows.Add(team.TeamID, team.TeamName, team.FoundedYear.ToString("yyyy"), team.Address, logo, team.Stadium, team.City, team.Nation);
                    }
                }
                else
                {
                    // Nếu không có kết quả, không cần thông báo, chỉ xóa DataGridView
                    dataGridViewTeams.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for teams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nút "Search" được nhấn
        private void btnSearchTeams_Click(object sender, EventArgs e)
        {
            SearchTeams();
        }

        // Xử lý sự kiện khi nội dung trong TextBox thay đổi
        private void searchTeams_TextChanged(object sender, EventArgs e)
        {
            SearchTeams();
        }

        // Xử lý sự kiện khi Form2 được load
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAllTeams();
            // Gán dữ liệu cho ComboBox
            cmbCity.DataSource = new BindingSource(cities, null);
            cmbNation.DataSource = new BindingSource(nations, null);
            cmbStadium.DataSource = new BindingSource(stadiums, null);

            cmbCity.SelectedIndex = -1; // Để trống khi mới mở form
            cmbNation.SelectedIndex = -1;
            cmbStadium.SelectedIndex = -1;
        }
        //xoá
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Lấy TeamID từ ô txtTeamID
            string teamID = txtTeamID.Text;

            // Kiểm tra nếu TeamID không rỗng
            if (!string.IsNullOrEmpty(teamID))
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa đội có TeamID: {teamID} không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Gọi phương thức xóa đội từ BUS
                        bool isDeleted = teamBUS.DeleteTeam(teamID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa thành công!");
                            LoadAllTeams(); // Tải lại danh sách đội
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đội với TeamID: " + teamID, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa đội: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đội để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<string> cities = new List<string> { "Hanoi", "Ho Chi Minh", "Da Nang", "Can Tho" };
        private List<string> nations = new List<string> { "Vietnam", "USA", "France", "Germany" };
        private List<string> stadiums = new List<string> { "My Dinh", "Thien Truong", "Hang Day", "Tan Son Nhat" };



        // Hàm tải danh sách đội vào DataGridView
        private void LoadTeams()
        {
            var teams = teamBUS.GetTeams();
            dataGridViewTeams.DataSource = teams;
        }

        private void TeamManagementForm_Load(object sender, EventArgs e)
        {
            LoadTeams(); // Tải dữ liệu lên DataGridView khi form mở
        }
        // them du lieu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string teamID = txtTeamID.Text;
            string teamName = txtTeamName.Text;
            string address = txtAddress.Text;
            string city = cmbCity.SelectedItem?.ToString();  // Lấy giá trị từ ComboBox
            string nation = cmbNation.SelectedItem?.ToString();
            string stadium = cmbStadium.SelectedItem?.ToString();
            DateTime foundedYear = dateTimePicker1.Value;

            // Xử lý logo (nếu cần, lưu đường dẫn hoặc xử lý ảnh)
            string logoPath = pictureBox1Logo.ImageLocation; // Ví dụ lấy đường dẫn hình ảnh

            // Tạo đối tượng Team
            Team team = new Team
            {
                TeamID = teamID,
                TeamName = teamName,
                Address = address,
                City = city,
                Nation = nation,
                Stadium = stadium,
                FoundedYear = foundedYear,
                Logo = logoPath // hoặc xử lý thêm tùy theo cách bạn lưu logo
            };

            // Gọi phương thức thêm đội bóng
            TeamBUS teamBUS = new TeamBUS();
            bool result = teamBUS.AddTeam(team);

            if (result)
            {
                MessageBox.Show("Team added successfully!");
                // Có thể thêm hành động làm mới form hoặc danh sách đội bóng
                LoadAllTeams(); // Tải lại danh sách đội
            }
            else
            {
                MessageBox.Show("Failed to add team!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Làm mới tất cả các trường nhập liệu
            txtTeamID.Clear();
            txtTeamName.Clear();
            txtAddress.Clear();
            cmbCity.SelectedIndex = -1; // Không chọn gì
            cmbNation.SelectedIndex = -1;
            cmbStadium.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1Logo.Image = null; // Hoặc xử lý theo cách bạn muốn
        }

        // upload logo:
        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại để chọn hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị logo trong PictureBox
                pictureBox1Logo.ImageLocation = openFileDialog.FileName;
            }
        }
        //lấy dữ liệu từ datagridview
        private void DataGridViewTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không phải hàng dữ liệu hợp lệ
            if (e.RowIndex < 0) return;

            // Lấy dữ liệu từ hàng được chọn
            DataGridViewRow selectedRow = dataGridViewTeams.Rows[e.RowIndex];
            txtTeamID.Text = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value?.ToString();
            txtTeamName.Text = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value?.ToString();
            // Lấy giá trị từ cell "Founded Year"
            var foundedYearValue = selectedRow.Cells["dataGridViewTextBoxColumn3"].Value?.ToString();

            // Kiểm tra xem giá trị có thể chuyển thành DateTime không
            if (DateTime.TryParse(foundedYearValue, out DateTime foundedYear))
            {
                dateTimePicker1.Value = foundedYear; // Gán giá trị hợp lệ cho DateTimePicker
            }
            else
            {
                // Nếu không thể chuyển đổi, gán giá trị mặc định (ví dụ: ngày hiện tại)
                dateTimePicker1.Value = DateTime.Now;
            }

            txtAddress.Text = selectedRow.Cells["dataGridViewTextBoxColumn4"].Value?.ToString();
            cmbCity.SelectedItem = selectedRow.Cells["dataGridViewTextBoxColumn6"].Value?.ToString();
            cmbNation.SelectedItem = selectedRow.Cells["dataGridViewTextBoxColumn7"].Value?.ToString();
            cmbStadium.SelectedItem = selectedRow.Cells["dataGridViewTextBoxColumn5"].Value?.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtTeamID.Text) || string.IsNullOrWhiteSpace(txtTeamName.Text))
            {
                MessageBox.Show("Team ID and Team Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new Team object with the values from the UI fields
            Team team = new Team
            {
                TeamID = txtTeamID.Text,
                TeamName = txtTeamName.Text,
                Address = txtAddress.Text,
                City = cmbCity.SelectedItem?.ToString(),
                Nation = cmbNation.SelectedItem?.ToString(),
                Stadium = cmbStadium.SelectedItem?.ToString(),
                FoundedYear = dateTimePicker1.Value,
                Logo = pictureBox1Logo.ImageLocation // Assuming you store logo location or image path
            };

            // Call the UpdateTeam method from TeamBUS
            TeamBUS teamBUS = new TeamBUS();
            bool result = teamBUS.UpdateTeam(team);

            if (result)
            {
                MessageBox.Show("Team updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllTeams(); // Reload the data grid after update
            }
            else
            {
                MessageBox.Show("Failed to update the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Logic khi click vào pictureBox1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
        // Sự kiện xử lý khi bấm nút btnPlayer
        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Player
            Player player = new Player();

            // Hiển thị form Club
            player.Show();

            // Ẩn form MainForm 
            this.Hide();
            this.Close();
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
    }
}
