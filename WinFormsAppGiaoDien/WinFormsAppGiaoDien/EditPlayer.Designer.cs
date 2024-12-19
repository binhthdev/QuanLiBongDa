namespace WinFormsAppGiaoDien
{
    partial class EditPlayer
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
            btnUpdate = new Button();
            btnUpload = new Button();
            pictureBox1 = new PictureBox();
            cbxteamID = new ComboBox();
            label1 = new Label();
            txtPlayerID = new TextBox();
            dateTimePickerPlayer = new DateTimePicker();
            cbxRole = new ComboBox();
            btnClear = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbPlayerName = new Label();
            txtNumberPlayer = new TextBox();
            txtNationality = new TextBox();
            ttxNamePlayer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(795, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 49);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(795, 138);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(125, 49);
            btnUpload.TabIndex = 35;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(795, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 118);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // cbxteamID
            // 
            cbxteamID.FormattingEnabled = true;
            cbxteamID.Location = new Point(163, 149);
            cbxteamID.Name = "cbxteamID";
            cbxteamID.Size = new Size(221, 28);
            cbxteamID.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(8, 154);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 51;
            label1.Text = "Team ID :";
            // 
            // txtPlayerID
            // 
            txtPlayerID.Location = new Point(163, 13);
            txtPlayerID.Name = "txtPlayerID";
            txtPlayerID.Size = new Size(221, 27);
            txtPlayerID.TabIndex = 50;
            // 
            // dateTimePickerPlayer
            // 
            dateTimePickerPlayer.Format = DateTimePickerFormat.Short;
            dateTimePickerPlayer.Location = new Point(564, 109);
            dateTimePickerPlayer.Name = "dateTimePickerPlayer";
            dateTimePickerPlayer.Size = new Size(221, 27);
            dateTimePickerPlayer.TabIndex = 49;
            // 
            // cbxRole
            // 
            cbxRole.FormattingEnabled = true;
            cbxRole.Location = new Point(564, 59);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(221, 28);
            cbxRole.TabIndex = 48;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(660, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 49);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(420, 112);
            label7.Name = "label7";
            label7.Size = new Size(141, 24);
            label7.TabIndex = 45;
            label7.Text = "Date of birth :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(420, 65);
            label6.Name = "label6";
            label6.Size = new Size(65, 24);
            label6.TabIndex = 44;
            label6.Text = "Role :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(420, 19);
            label5.Name = "label5";
            label5.Size = new Size(84, 24);
            label5.TabIndex = 46;
            label5.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(8, 109);
            label3.Name = "label3";
            label3.Size = new Size(123, 24);
            label3.TabIndex = 43;
            label3.Text = "Nationality :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(8, 62);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 42;
            label2.Text = "Name :";
            // 
            // lbPlayerName
            // 
            lbPlayerName.AutoSize = true;
            lbPlayerName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbPlayerName.Location = new Point(8, 16);
            lbPlayerName.Name = "lbPlayerName";
            lbPlayerName.Size = new Size(107, 24);
            lbPlayerName.TabIndex = 41;
            lbPlayerName.Text = "Player ID :";
            // 
            // txtNumberPlayer
            // 
            txtNumberPlayer.Location = new Point(564, 13);
            txtNumberPlayer.Name = "txtNumberPlayer";
            txtNumberPlayer.Size = new Size(221, 27);
            txtNumberPlayer.TabIndex = 39;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(163, 106);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(221, 27);
            txtNationality.TabIndex = 38;
            // 
            // ttxNamePlayer
            // 
            ttxNamePlayer.Location = new Point(163, 59);
            ttxNamePlayer.Name = "ttxNamePlayer";
            ttxNamePlayer.Size = new Size(221, 27);
            ttxNamePlayer.TabIndex = 40;
            // 
            // EditPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 253);
            Controls.Add(cbxteamID);
            Controls.Add(label1);
            Controls.Add(txtPlayerID);
            Controls.Add(dateTimePickerPlayer);
            Controls.Add(cbxRole);
            Controls.Add(btnClear);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbPlayerName);
            Controls.Add(txtNumberPlayer);
            Controls.Add(txtNationality);
            Controls.Add(ttxNamePlayer);
            Controls.Add(btnUpdate);
            Controls.Add(btnUpload);
            Controls.Add(pictureBox1);
            Name = "EditPlayer";
            Text = "EditPlayer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnUpload;
        private PictureBox pictureBox1;
        private ComboBox cbxteamID;
        private Label label1;
        private TextBox txtPlayerID;
        private DateTimePicker dateTimePickerPlayer;
        private ComboBox cbxRole;
        private Button btnClear;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label lbPlayerName;
        private TextBox txtNumberPlayer;
        private TextBox txtNationality;
        private TextBox ttxNamePlayer;
    }
}