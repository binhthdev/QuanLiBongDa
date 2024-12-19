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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox1_Click;
            btnClub.Click += button2_Click;
            btnPlayer.Click += button4_Click;
            btnReferee.Click += button3_Click;
            btnAdd.Click += buttonAdd_Click;
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
            Player player = new Player();

            // Hiển thị form Club
            player.Show();

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

        // Sự kiện xử lý khi bấm nút btnPlayer
        private void button4_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Player
            Player player = new Player();

            // Hiển thị form Player
            player.Show();

            this.Close();
            this.Hide();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Player
            ResultAdd resultAdd = new ResultAdd();

            // Hiển thị form Player
            resultAdd.Show();

        }
    }
}
