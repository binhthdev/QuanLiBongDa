using System.Security.Cryptography.Xml;

namespace WinFormsAppGiaoDien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnClub.Click += button1_Click;
            btnPlayer.Click += button2_Click;
            btnResult.Click += button4_Click;
            btnReferee.Click += button3_Click;
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
