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
            btnAdd.Click += BtnAdd_Click;
            btnClear.Click += BtnClear_Click;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick; // Sự kiện xoá và Cập nhật
            LoadData(); // Tải dữ liệu khi khởi động
            txtSeachClub.TextChanged += TxtSeachClub_TextChanged; // Sự kiện tìm kiếm
            btnEdit.Click += BtnEdit_Click;
            LoadNationalities();
        }

        private void LoadNationalities()
        {
            // Example list of countries/nationalities
            List<string> nationalities = new List<string>
            {
                "Vietnam",
                "USA",
                "Germany",
                "France",
                "Brazil",
                "Argentina"
            };

            // Add the nationalities to the ComboBox
            cmbNationality.DataSource = nationalities;
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu người dùng chọn nút sửa (Edit)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng đã chọn và điền vào các TextBox
                txtRefereeID.Text = dataGridView1.Rows[e.RowIndex].Cells["RefereeID"].Value.ToString();
                ttxNameReferee.Text = dataGridView1.Rows[e.RowIndex].Cells["RefereeName"].Value.ToString();
                cmbNationality.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["Nationality"].Value.ToString();
                dateTimePickerPlayer.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DateOfBirth"].Value);
            }
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

        // them du lieu
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng RefereeDTO
                RefereeDTO referee = new RefereeDTO
                {
                    RefereeID = txtRefereeID.Text.Trim(),
                    RefereeName = ttxNameReferee.Text.Trim(),
                    Nationality = cmbNationality.SelectedItem.ToString(),
                    DateOfBirth = dateTimePickerPlayer.Value
                };

                // Kiểm tra và thêm dữ liệu thông qua RefereeBUS
                if (refereeBUS.AddReferee(referee))
                {
                    MessageBox.Show("Referee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();  // Tải lại dữ liệu trong DataGridView
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add referee. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtRefereeID.Text = string.Empty;
            ttxNameReferee.Text = string.Empty;
            cmbNationality.SelectedIndex=-1;
            dateTimePickerPlayer.Value = DateTime.Now;
        }

        // Sự kiện khi bấm nút Edit
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các TextBox không rỗng
                if (string.IsNullOrEmpty(txtRefereeID.Text.Trim()) ||
                    string.IsNullOrEmpty(ttxNameReferee.Text.Trim()) ||
                    cmbNationality.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng RefereeDTO với các giá trị từ các TextBox
                RefereeDTO referee = new RefereeDTO
                {
                    RefereeID = txtRefereeID.Text.Trim(),
                    RefereeName = ttxNameReferee.Text.Trim(),
                    Nationality = cmbNationality.SelectedItem.ToString(),
                    DateOfBirth = dateTimePickerPlayer.Value
                };

                // Gọi hàm cập nhật trong RefereeBUS
                if (refereeBUS.UpdateReferee(referee))
                {
                    MessageBox.Show("Referee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Tải lại dữ liệu từ cơ sở dữ liệu
                    ClearFields(); // Xóa các trường nhập liệu
                }
                else
                {
                    MessageBox.Show("Failed to update referee. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
