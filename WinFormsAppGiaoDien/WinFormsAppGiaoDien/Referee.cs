using BUS;
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
    public partial class Referee : Form
    {
        private RefereeBUS refereeBUS = new RefereeBUS();
        public Referee()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox1_Click;
            btnClub.Click += button1_Click;
            btnPlayer.Click += button2_Click;
            btnResult.Click += button4_Click;
            btnReferee.Click += button3_Click;
            btnAdd.Click += buttonAdd_Click;
            btnEdit.Click += buttonEdit_Click;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick; // Sự kiện xoá
            LoadData(); // Tải dữ liệu khi khởi động
            txtSeachClub.TextChanged += TxtSeachClub_TextChanged; // Sự kiện tìm kiếm
        }
        // Logic khi click vào pictureBox1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        // Sự kiện xử lý khi bấm nút btnClub
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Club
            Club clubForm = new Club();

            // Hiển thị form Club
            clubForm.Show();

            // Ẩn form MainForm 
            this.Hide();
        }

        // Sự kiện xử lý khi bấm nút btnPlayer
        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Player
            Player player = new Player();

            // Hiển thị form Player
            player.Show();

            // Ẩn form MainForm 
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

            // Ẩn form MainForm 
            this.Hide();
        }
        // Sự kiện xử lý khi bấm nút add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form add
            AddReferee addReferee = new AddReferee();

            // Hiển thị form add
            addReferee.Show();
        }
        // Sự kiện xử lý khi bấm nút edit
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form edit
            EditReferee editReferee = new EditReferee();

            // Hiển thị form edit
            editReferee.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Xóa trọng tài
                string refereeID = dataGridView1.Rows[e.RowIndex].Cells["RefereeID"].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete referee {refereeID}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (refereeBUS.DeleteReferee(refereeID))
                    {
                        MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadData()
        {
            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = refereeBUS.GetAllReferees();

            // Kiểm tra và thêm cột Delete nếu chưa có
            if (dataGridView1.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Actions",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridView1.Columns.Add(deleteColumn);
            }

            // Thay đổi chiều rộng của các cột
            dataGridView1.Columns["RefereeID"].Width = 250;         // Cột RefereeID
            dataGridView1.Columns["RefereeName"].Width = 250;       // Cột RefereeName
            dataGridView1.Columns["Nationality"].Width = 150;       // Cột Nationality
            dataGridView1.Columns["DateOfBirth"].Width = 220;       // Cột DateOfBirth
            dataGridView1.Columns["Delete"].Width = 100;            // Cột Delete (nếu có)

            // Đảm bảo rằng cột Delete có thể tự động thay đổi kích thước
            dataGridView1.Columns["Delete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }




        private void TxtSeachClub_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm trọng tài theo tên hoặc quốc tịch
            string keyword = txtSeachClub.Text.Trim();
            dataGridView1.DataSource = refereeBUS.SearchReferees(keyword);
        }
    }
}
