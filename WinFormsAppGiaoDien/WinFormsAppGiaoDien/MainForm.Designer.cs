namespace WinFormsAppGiaoDien
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            Logout = new Button();
            Exit = new Button();
            Coach = new Button();
            Referee = new Button();
            Ranking = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            AnhNen = new PictureBox();
            Welcome = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnhNen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(Coach);
            panel1.Controls.Add(Referee);
            panel1.Controls.Add(Ranking);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 753);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Logout
            // 
            Logout.Location = new Point(0, 702);
            Logout.Name = "Logout";
            Logout.Size = new Size(250, 51);
            Logout.TabIndex = 1;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Location = new Point(0, 560);
            Exit.Name = "Exit";
            Exit.Size = new Size(250, 51);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // Coach
            // 
            Coach.Location = new Point(0, 503);
            Coach.Name = "Coach";
            Coach.Size = new Size(250, 51);
            Coach.TabIndex = 1;
            Coach.Text = "Coach";
            Coach.UseVisualStyleBackColor = true;
            // 
            // Referee
            // 
            Referee.Location = new Point(0, 446);
            Referee.Name = "Referee";
            Referee.Size = new Size(250, 51);
            Referee.TabIndex = 1;
            Referee.Text = "Referee";
            Referee.UseVisualStyleBackColor = true;
            // 
            // Ranking
            // 
            Ranking.Location = new Point(0, 389);
            Ranking.Name = "Ranking";
            Ranking.Size = new Size(250, 51);
            Ranking.TabIndex = 1;
            Ranking.Text = "Ranking";
            Ranking.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 332);
            button4.Name = "button4";
            button4.Size = new Size(250, 51);
            button4.TabIndex = 1;
            button4.Text = "Result";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 275);
            button3.Name = "button3";
            button3.Size = new Size(250, 51);
            button3.TabIndex = 1;
            button3.Text = "Player";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 218);
            button2.Name = "button2";
            button2.Size = new Size(250, 51);
            button2.TabIndex = 1;
            button2.Text = "Match Schendule";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(0, 161);
            button1.Name = "button1";
            button1.Size = new Size(250, 51);
            button1.TabIndex = 1;
            button1.Text = "Club";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tải_xuống__3_;
            pictureBox1.Location = new Point(34, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AnhNen
            // 
            AnhNen.Image = (Image)resources.GetObject("AnhNen.Image");
            AnhNen.Location = new Point(249, 0);
            AnhNen.Name = "AnhNen";
            AnhNen.Size = new Size(933, 647);
            AnhNen.SizeMode = PictureBoxSizeMode.StretchImage;
            AnhNen.TabIndex = 1;
            AnhNen.TabStop = false;
            // 
            // Welcome
            // 
            Welcome.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Welcome.Location = new Point(249, 676);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(326, 52);
            Welcome.TabIndex = 2;
            Welcome.Text = "Welcome Admin";
            Welcome.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tải_xuống;
            pictureBox2.Location = new Point(905, 653);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1182, 753);
            Controls.Add(pictureBox2);
            Controls.Add(Welcome);
            Controls.Add(AnhNen);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnhNen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button Logout;
        private Button Exit;
        private Button Coach;
        private Button Referee;
        private Button Ranking;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox AnhNen;
        private Button Welcome;
        private PictureBox pictureBox2;
    }
}
