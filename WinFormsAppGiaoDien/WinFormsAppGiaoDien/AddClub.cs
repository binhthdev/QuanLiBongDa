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
    public partial class AddClub : Form
    {
        public AddClub()
        {
            InitializeComponent();
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUploadLogo.Click += new System.EventHandler(this.btnUploadLogo_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        }

        // them du lieu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string teamID = txtTeamID.Text;
            string teamName = txtTeamName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string nation = txtNation.Text;
            string stadium = txtStadium.Text;
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
            txtCity.Clear();
            txtNation.Clear();
            txtStadium.Clear();
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


    }
}
