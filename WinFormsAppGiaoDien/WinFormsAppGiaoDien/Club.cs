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
            btnAdd.Click += btnAddClub_Click;
            btnEdit.Click += btnEditClub_Click;
            this.Load += Form2_Load; // Đảm bảo sự kiện Load được liên kết
            this.searchTeams.TextChanged += searchTeams_TextChanged; // Liên kết sự kiện TextChanged
            this.btnDelete.Click += btnDelete_Click;
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
            // Tạo một thể hiện của form Club
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
        // Sự kiện xử lý khi bấm nút add club
        private void btnAddClub_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form add club
            AddClub addClub = new AddClub();

            // Hiển thị form add club
            addClub.Show();
        }
        // Sự kiện xử lý khi bấm nút edit club
        private void btnEditClub_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form edit club
            EditClub editClub = new EditClub();

            // Hiển thị form edit club
            editClub.Show();

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
        }
        //xoá
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập TeamID
            string teamID = Microsoft.VisualBasic.Interaction.InputBox("Nhập TeamID cần xóa:", "Xóa đội", "");

            // Kiểm tra nếu teamID không rỗng
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
                MessageBox.Show("Vui lòng nhập TeamID cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


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
    }
}
