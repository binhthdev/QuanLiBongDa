namespace WinFormsAppGiaoDien
{
    partial class AddPlayer
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
            btnAdd = new Button();
            btnClear = new Button();
            btnUpload = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbCLBID = new Label();
            txtNationality = new TextBox();
            ttxNamePlayer = new TextBox();
            txtNumberPlayer = new TextBox();
            label5 = new Label();
            cbbRole = new ComboBox();
            dateTimePickerPlayer = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(795, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 49);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(664, 138);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 49);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(795, 138);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(125, 49);
            btnUpload.TabIndex = 19;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(795, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 118);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(424, 110);
            label7.Name = "label7";
            label7.Size = new Size(141, 24);
            label7.TabIndex = 16;
            label7.Text = "Date of birth :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(424, 63);
            label6.Name = "label6";
            label6.Size = new Size(65, 24);
            label6.TabIndex = 15;
            label6.Text = "Role :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(123, 24);
            label3.TabIndex = 13;
            label3.Text = "Nationality :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 12;
            label2.Text = "Name :";
            // 
            // lbCLBID
            // 
            lbCLBID.AutoSize = true;
            lbCLBID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbCLBID.Location = new Point(12, 14);
            lbCLBID.Name = "lbCLBID";
            lbCLBID.Size = new Size(88, 24);
            lbCLBID.TabIndex = 11;
            lbCLBID.Text = "CLB ID :";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(167, 104);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(221, 27);
            txtNationality.TabIndex = 6;
            // 
            // ttxNamePlayer
            // 
            ttxNamePlayer.Location = new Point(167, 57);
            ttxNamePlayer.Name = "ttxNamePlayer";
            ttxNamePlayer.Size = new Size(221, 27);
            ttxNamePlayer.TabIndex = 10;
            // 
            // txtNumberPlayer
            // 
            txtNumberPlayer.Location = new Point(568, 11);
            txtNumberPlayer.Name = "txtNumberPlayer";
            txtNumberPlayer.Size = new Size(221, 27);
            txtNumberPlayer.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(424, 17);
            label5.Name = "label5";
            label5.Size = new Size(84, 24);
            label5.TabIndex = 17;
            label5.Text = "Number";
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(568, 57);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(221, 28);
            cbbRole.TabIndex = 22;
            // 
            // dateTimePickerPlayer
            // 
            dateTimePickerPlayer.Format = DateTimePickerFormat.Short;
            dateTimePickerPlayer.Location = new Point(568, 107);
            dateTimePickerPlayer.Name = "dateTimePickerPlayer";
            dateTimePickerPlayer.Size = new Size(221, 27);
            dateTimePickerPlayer.TabIndex = 23;
            // 
            // label1
            // 
            label1.Location = new Point(167, 14);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 24;
            label1.Text = "id Clb";
            label1.Click += label1_Click;
            // 
            // AddPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 253);
            Controls.Add(label1);
            Controls.Add(dateTimePickerPlayer);
            Controls.Add(cbbRole);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnUpload);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbCLBID);
            Controls.Add(txtNumberPlayer);
            Controls.Add(txtNationality);
            Controls.Add(ttxNamePlayer);
            Name = "AddPlayer";
            Text = "Add Player";
            Load += AddPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private Button btnClear;
        private Button btnUpload;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbCLBID;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox txtNationality;
        private TextBox ttxNamePlayer;
        private TextBox txtNumberPlayer;
        private Label label5;
        private ComboBox cbbRole;
        private DateTimePicker dateTimePickerPlayer;
        private Label label1;
    }
}