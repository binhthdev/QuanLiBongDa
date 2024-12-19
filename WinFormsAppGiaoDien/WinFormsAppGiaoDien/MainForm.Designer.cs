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
            btnLogout = new Button();
            btnExit = new Button();
            btnCoach = new Button();
            btnReferee = new Button();
            btnRanking = new Button();
            btnResult = new Button();
            btnPlayer = new Button();
            btnMschendule = new Button();
            btnClub = new Button();
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
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnCoach);
            panel1.Controls.Add(btnReferee);
            panel1.Controls.Add(btnRanking);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(btnPlayer);
            panel1.Controls.Add(btnMschendule);
            panel1.Controls.Add(btnClub);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 753);
  
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(0, 702);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 51);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(0, 560);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 51);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCoach
            // 
            btnCoach.Location = new Point(0, 503);
            btnCoach.Name = "btnCoach";
            btnCoach.Size = new Size(250, 51);
            btnCoach.TabIndex = 1;
            btnCoach.Text = "Coach";
            btnCoach.UseVisualStyleBackColor = true;
            // 
            // btnReferee
            // 
            btnReferee.Location = new Point(0, 446);
            btnReferee.Name = "btnReferee";
            btnReferee.Size = new Size(250, 51);
            btnReferee.TabIndex = 1;
            btnReferee.Text = "Referee";
            btnReferee.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            btnRanking.Location = new Point(0, 389);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(250, 51);
            btnRanking.TabIndex = 1;
            btnRanking.Text = "Ranking";
            btnRanking.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(0, 332);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(250, 51);
            btnResult.TabIndex = 1;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = true;
            // 
            // btnPlayer
            // 
            btnPlayer.Location = new Point(0, 275);
            btnPlayer.Name = "btnPlayer";
            btnPlayer.Size = new Size(250, 51);
            btnPlayer.TabIndex = 1;
            btnPlayer.Text = "Player";
            btnPlayer.UseVisualStyleBackColor = true;
            // 
            // btnMschendule
            // 
            btnMschendule.Location = new Point(0, 218);
            btnMschendule.Name = "btnMschendule";
            btnMschendule.Size = new Size(250, 51);
            btnMschendule.TabIndex = 1;
            btnMschendule.Text = "Match Schendule";
            btnMschendule.UseVisualStyleBackColor = true;
            // 
            // btnClub
            // 
            btnClub.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnClub.ForeColor = SystemColors.ActiveCaptionText;
            btnClub.Location = new Point(0, 161);
            btnClub.Name = "btnClub";
            btnClub.Size = new Size(250, 51);
            btnClub.TabIndex = 1;
            btnClub.Text = "Club";
            btnClub.UseVisualStyleBackColor = true;
            btnClub.Click += button1_Click;
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
        private Button btnClub;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnExit;
        private Button btnCoach;
        private Button btnReferee;
        private Button btnRanking;
        private Button btnResult;
        private Button btnPlayer;
        private Button btnMschendule;
        private PictureBox AnhNen;
        private Button Welcome;
        private PictureBox pictureBox2;
    }
}
