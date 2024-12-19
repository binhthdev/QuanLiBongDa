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
            btnAdd.Click += buttonAdd_Click;
            btnEdit.Click += buttonEdit_Click;
            this.Load += Player_Load;
            this.searchPlayer.TextChanged += searchPlayer_TextChanged;  // Thêm sự kiện TextChanged cho TextBox tìm kiếm                                                                        // Thêm sự kiện cho nút Delete
            btnDelete.Click += btnDelete_Click;
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
        // Sự kiện xử lý khi bấm nút add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form add
            AddPlayer addPlayer = new AddPlayer();

            // Hiển thị form add
            addPlayer.Show();

        }
        // Sự kiện xử lý khi bấm nút edit
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form edit
            EditPlayer editPlayer = new EditPlayer();

            // Hiển thị form edit
            editPlayer.Show();

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


    }
}
