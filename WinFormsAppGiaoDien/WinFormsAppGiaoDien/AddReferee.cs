using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WinFormsAppGiaoDien
{
    public partial class AddReferee : Form
    {
        private RefereeBUS refereeBUS = new RefereeBUS();

        public AddReferee()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng RefereeDTO
                RefereeDTO referee = new RefereeDTO
                {
                    RefereeID = txtRefereeID.Text.Trim(),
                    RefereeName = ttxNameReferee.Text.Trim(),
                    Nationality = txtNationality.Text.Trim(),
                    DateOfBirth = dateTimePickerPlayer.Value
                };

                // Kiểm tra và thêm dữ liệu thông qua RefereeBUS
                if (refereeBUS.AddReferee(referee))
                {
                    MessageBox.Show("Referee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNationality.Text = string.Empty;
            dateTimePickerPlayer.Value = DateTime.Now;
        }
    }
}
