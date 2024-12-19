using BUS;
using DAL;
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
    public partial class AddPlayer : Form
    {
        private PlayerBUS playerBUS = new PlayerBUS();

        public AddPlayer()
        {
            InitializeComponent();
            LoadTeamData();  
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            LoadPositionData();  
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnUpload.Click += new EventHandler(this.btnUpload_Click);
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
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            PlayerDTO newPlayer = new PlayerDTO
            {
                PlayerID = txtPlayerID.Text,  
                PlayerName = ttxNamePlayer.Text,  
                Age = dateTimePickerPlayer.Value,  
                Position = cbbRole.Text,  
                ShirtNumber = txtNumberPlayer.Text,  
                Nationality = txtNationality.Text, 
                TeamID = cbxteamID.SelectedValue.ToString(),  
                Image = pictureBox1.ImageLocation  
            };

            bool isAdded = playerBUS.AddPlayer(newPlayer);

            if (isAdded)
            {
                MessageBox.Show("Player added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNationality.Clear();
            cbbRole.SelectedIndex = -1;  
            cbxteamID.SelectedIndex = -1; 
            pictureBox1.Image = null;  
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
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
