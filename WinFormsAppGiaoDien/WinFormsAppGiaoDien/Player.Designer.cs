namespace WinFormsAppGiaoDien
{
    partial class Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            btnExit = new Button();
            btnCoach = new Button();
            btnReferee = new Button();
            btnRanking = new Button();
            btnResult = new Button();
            btnPlayer = new Button();
            btnMatch = new Button();
            btnClub = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(btnMatch);
            panel1.Controls.Add(btnClub);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 753);
            panel1.TabIndex = 15;
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
            btnPlayer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnPlayer.Location = new Point(0, 275);
            btnPlayer.Name = "btnPlayer";
            btnPlayer.Size = new Size(250, 51);
            btnPlayer.TabIndex = 1;
            btnPlayer.Text = "Player";
            btnPlayer.UseVisualStyleBackColor = true;
            // 
            // btnMatch
            // 
            btnMatch.Font = new Font("Segoe UI", 9F);
            btnMatch.Location = new Point(0, 218);
            btnMatch.Name = "btnMatch";
            btnMatch.Size = new Size(250, 51);
            btnMatch.TabIndex = 1;
            btnMatch.Text = "Match Schendule";
            btnMatch.UseVisualStyleBackColor = true;
            // 
            // btnClub
            // 
            btnClub.BackColor = Color.Snow;
            btnClub.Font = new Font("Segoe UI", 9F);
            btnClub.ForeColor = SystemColors.ActiveCaptionText;
            btnClub.Location = new Point(0, 161);
            btnClub.Name = "btnClub";
            btnClub.Size = new Size(250, 51);
            btnClub.TabIndex = 1;
            btnClub.Text = "Club";
            btnClub.UseVisualStyleBackColor = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(733, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 19;
            label1.Text = "Player";
            //label1.Click += this.label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1099, 680);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 51);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1021, 680);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(71, 51);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 547);
            dataGridView1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(654, 671);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Name = "Player";
            Text = "Player";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnExit;
        private Button btnCoach;
        private Button btnReferee;
        private Button btnRanking;
        private Button btnResult;
        private Button btnPlayer;
        private Button btnMatch;
        private Button btnClub;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}