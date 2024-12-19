namespace WinFormsAppGiaoDien
{
    partial class EditReferee
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
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbPlayerName = new Label();
            txtNationality = new TextBox();
            ttxNameReferee = new TextBox();
            dateTimePickerPlayer = new DateTimePicker();
            txtRefereeID = new TextBox();
            btnClear = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(14, 150);
            label7.Name = "label7";
            label7.Size = new Size(141, 24);
            label7.TabIndex = 16;
            label7.Text = "Date of birth :";
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
            // lbPlayerName
            // 
            lbPlayerName.AutoSize = true;
            lbPlayerName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbPlayerName.Location = new Point(12, 14);
            lbPlayerName.Name = "lbPlayerName";
            lbPlayerName.Size = new Size(121, 24);
            lbPlayerName.TabIndex = 11;
            lbPlayerName.Text = "Referee ID :";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(167, 104);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(221, 27);
            txtNationality.TabIndex = 6;
            // 
            // ttxNameReferee
            // 
            ttxNameReferee.Location = new Point(167, 57);
            ttxNameReferee.Name = "ttxNameReferee";
            ttxNameReferee.Size = new Size(221, 27);
            ttxNameReferee.TabIndex = 10;
            // 
            // dateTimePickerPlayer
            // 
            dateTimePickerPlayer.Format = DateTimePickerFormat.Short;
            dateTimePickerPlayer.Location = new Point(167, 147);
            dateTimePickerPlayer.Name = "dateTimePickerPlayer";
            dateTimePickerPlayer.Size = new Size(221, 27);
            dateTimePickerPlayer.TabIndex = 23;
            // 
            // txtRefereeID
            // 
            txtRefereeID.Location = new Point(167, 11);
            txtRefereeID.Name = "txtRefereeID";
            txtRefereeID.Size = new Size(221, 27);
            txtRefereeID.TabIndex = 24;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(14, 193);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(184, 49);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(204, 193);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(184, 49);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit\r\n";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // EditReferee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 253);
            Controls.Add(txtRefereeID);
            Controls.Add(dateTimePickerPlayer);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbPlayerName);
            Controls.Add(txtNationality);
            Controls.Add(ttxNameReferee);
            Name = "EditReferee";
            Text = "Add Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbPlayerName;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox txtNationality;
        private TextBox ttxNameReferee;
        private DateTimePicker dateTimePickerPlayer;
        private TextBox txtRefereeID;
        private Button btnClear;
        private Button btnEdit;
    }
}