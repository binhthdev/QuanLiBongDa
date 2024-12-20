using System.Windows.Forms;

namespace WinFormsAppGiaoDien
{
    partial class Club
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
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
            dataGridViewTeams = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            logoColumn = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            searchTeams = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnUploadLogo = new Button();
            pictureBox1Logo = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtTeamID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtTeamName = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            cmbCity = new ComboBox();
            cmbNation = new ComboBox();
            cmbStadium = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Logo).BeginInit();
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
            panel1.TabIndex = 1;
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
            btnCoach.Font = new Font("Segoe UI", 9F);
            btnCoach.Location = new Point(0, 503);
            btnCoach.Name = "btnCoach";
            btnCoach.Size = new Size(250, 51);
            btnCoach.TabIndex = 1;
            btnCoach.Text = "Coach";
            btnCoach.UseVisualStyleBackColor = true;
            // 
            // btnReferee
            // 
            btnReferee.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // btnMatch
            // 
            btnMatch.Location = new Point(0, 218);
            btnMatch.Name = "btnMatch";
            btnMatch.Size = new Size(250, 51);
            btnMatch.TabIndex = 1;
            btnMatch.Text = "Match Schendule";
            btnMatch.UseVisualStyleBackColor = true;
            // 
            // btnClub
            // 
            btnClub.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClub.ForeColor = SystemColors.ActiveCaptionText;
            btnClub.Location = new Point(0, 161);
            btnClub.Name = "btnClub";
            btnClub.Size = new Size(250, 51);
            btnClub.TabIndex = 1;
            btnClub.Text = "Club";
            btnClub.UseVisualStyleBackColor = true;
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
            // dataGridViewTeams
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeams.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, logoColumn, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewTeams.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTeams.Location = new Point(256, 64);
            dataGridViewTeams.Name = "dataGridViewTeams";
            dataGridViewTeams.RowHeadersWidth = 51;
            dataGridViewTeams.RowTemplate.Height = 100;
            dataGridViewTeams.Size = new Size(903, 582);
            dataGridViewTeams.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn1.HeaderText = "Team ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTextBoxColumn2.HeaderText = "Team Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn3.HeaderText = "Founded Year";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn4.HeaderText = "Address";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // logoColumn
            // 
            logoColumn.HeaderText = "Logo";
            logoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            logoColumn.MinimumWidth = 6;
            logoColumn.Name = "logoColumn";
            logoColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Stadium";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "City";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Nation";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 200;
            // 
            // searchTeams
            // 
            searchTeams.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            searchTeams.Location = new Point(517, 680);
            searchTeams.Name = "searchTeams";
            searchTeams.PlaceholderText = "Search here";
            searchTeams.Size = new Size(400, 34);
            searchTeams.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(733, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Club";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1312, 665);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 49);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUploadLogo
            // 
            btnUploadLogo.Location = new Point(1379, 189);
            btnUploadLogo.Name = "btnUploadLogo";
            btnUploadLogo.Size = new Size(125, 49);
            btnUploadLogo.TabIndex = 10;
            btnUploadLogo.Text = "Upload";
            btnUploadLogo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1Logo
            // 
            pictureBox1Logo.BackColor = Color.Silver;
            pictureBox1Logo.Location = new Point(1379, 64);
            pictureBox1Logo.Name = "pictureBox1Logo";
            pictureBox1Logo.Size = new Size(125, 118);
            pictureBox1Logo.TabIndex = 9;
            pictureBox1Logo.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1347, 403);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2024, 12, 13, 16, 17, 34, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(1192, 405);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 14;
            label4.Text = "Day Build :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(1192, 350);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 15;
            label3.Text = "City :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(1192, 303);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 16;
            label2.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(1192, 257);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 17;
            label5.Text = "CLB ID :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1347, 300);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(221, 27);
            txtAddress.TabIndex = 12;
            // 
            // txtTeamID
            // 
            txtTeamID.Location = new Point(1347, 254);
            txtTeamID.Name = "txtTeamID";
            txtTeamID.Size = new Size(221, 27);
            txtTeamID.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(1192, 549);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 22;
            label7.Text = "Stadium :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(1192, 502);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 23;
            label6.Text = "Nation :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(1192, 456);
            label8.Name = "label8";
            label8.Size = new Size(122, 24);
            label8.TabIndex = 24;
            label8.Text = "CLB Name :";
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(1347, 453);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(221, 27);
            txtTeamName.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1308, 597);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 49);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1443, 665);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 49);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1443, 597);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 49);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(1347, 350);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(221, 28);
            cmbCity.TabIndex = 28;
            // 
            // cmbNation
            // 
            cmbNation.FormattingEnabled = true;
            cmbNation.Location = new Point(1347, 498);
            cmbNation.Name = "cmbNation";
            cmbNation.Size = new Size(221, 28);
            cmbNation.TabIndex = 29;
            // 
            // cmbStadium
            // 
            cmbStadium.FormattingEnabled = true;
            cmbStadium.Location = new Point(1347, 545);
            cmbStadium.Name = "cmbStadium";
            cmbStadium.Size = new Size(221, 28);
            cmbStadium.TabIndex = 30;
            // 
            // Club
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1619, 753);
            Controls.Add(cmbStadium);
            Controls.Add(cmbNation);
            Controls.Add(cmbCity);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(txtTeamName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(txtTeamID);
            Controls.Add(btnUploadLogo);
            Controls.Add(pictureBox1Logo);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(searchTeams);
            Controls.Add(dataGridViewTeams);
            Controls.Add(panel1);
            Name = "Club";
            Text = "Club";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeams).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Logo).EndInit();
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
        private DataGridView dataGridViewTeams;
        private TextBox searchTeams;
        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewImageColumn logoColumn;
        private Button btnDelete;
        private Button btnUploadLogo;
        private PictureBox pictureBox1Logo;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtAddress;
        private TextBox txtTeamID;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox txtTeamName;
        private Button btnAdd;
        private Button btnClear;
        private Button btnEdit;
        private ComboBox cmbCity;
        private ComboBox cmbNation;
        private ComboBox cmbStadium;
    }
}