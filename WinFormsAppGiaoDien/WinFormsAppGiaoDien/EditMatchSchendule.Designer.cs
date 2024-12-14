namespace WinFormsAppGiaoDien
{
    partial class EditMatchSchendule
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
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(566, 24);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(221, 28);
            comboBox4.TabIndex = 32;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(173, 130);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(221, 28);
            comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(173, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 28);
            comboBox2.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(566, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 28);
            comboBox1.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(566, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.Value = new DateTime(2024, 12, 13, 16, 17, 34, 0);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(662, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 49);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(423, 158);
            label7.Name = "label7";
            label7.Size = new Size(0, 24);
            label7.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(439, 132);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 27;
            label6.Text = "Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(436, 83);
            label5.Name = "label5";
            label5.Size = new Size(121, 24);
            label5.TabIndex = 29;
            label5.Text = "Visit Team :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(436, 28);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 26;
            label3.Text = "Referee :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(11, 136);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 25;
            label2.Text = "Stadium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(11, 83);
            label1.Name = "label1";
            label1.Size = new Size(134, 24);
            label1.TabIndex = 24;
            label1.Text = "Home Team :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(11, 28);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 24;
            label4.Text = "ID Match :";
            // 
            // label8
            // 
            label8.Location = new Point(173, 30);
            label8.Name = "label8";
            label8.Size = new Size(221, 25);
            label8.TabIndex = 36;
            label8.Text = "id Match";
            // 
            // EditMatchSchendule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 253);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditMatchSchendule";
            Text = "Edit Match Schendule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnUpdate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label8;
    }
}