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
    public partial class EditReferee : Form
    {
        public EditReferee()
        {
            InitializeComponent();
            btnEdit.Click += btnEdit_Click;
        }
        public void LoadRefereeData(RefereeDTO referee)
        {
            txtRefereeID.Text = referee.RefereeID;
            ttxNameReferee.Text = referee.RefereeName;
            txtNationality.Text = referee.Nationality;
            dateTimePickerPlayer.Value = referee.DateOfBirth;
        }


        // Sự kiện khi nhấn nút Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và DateTimePicker
            string refereeID = txtRefereeID.Text.Trim();
            string refereeName = ttxNameReferee.Text.Trim();
            string nationality = txtNationality.Text.Trim();
            DateTime dateOfBirth = dateTimePickerPlayer.Value;

            // Kiểm tra xem các trường có hợp lệ không
            if (string.IsNullOrEmpty(refereeID) || string.IsNullOrEmpty(refereeName) || string.IsNullOrEmpty(nationality))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng RefereeDTO
            RefereeDTO updatedReferee = new RefereeDTO
            {
                RefereeID = refereeID,
                RefereeName = refereeName,
                Nationality = nationality,
                DateOfBirth = dateOfBirth
            };

            // Gọi phương thức UpdateReferee từ RefereeBUS
            RefereeBUS refereeBUS = new RefereeBUS();
            bool result = refereeBUS.UpdateReferee(updatedReferee);

            if (result)
            {
                MessageBox.Show("Referee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi cập nhật thành công
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
