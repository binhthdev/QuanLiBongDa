namespace WinFormsAppGiaoDien
{
    partial class AddClub
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            btnUpload = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 1;
            label1.Text = "CLB ID :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 1;
            label2.Text = "Address :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 1;
            label3.Text = "City :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 1;
            label4.Text = "Day Build :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(568, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 27);
            textBox5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(424, 26);
            label5.Name = "label5";
            label5.Size = new Size(122, 24);
            label5.TabIndex = 1;
            label5.Text = "CLB Name :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(568, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 27);
            textBox6.TabIndex = 0;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(424, 72);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 1;
            label6.Text = "Nation :";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(568, 113);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(221, 27);
            textBox7.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(424, 119);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 1;
            label7.Text = "Stadium :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(795, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 118);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(795, 147);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(125, 49);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(795, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 49);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(664, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 49);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(167, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2024, 12, 13, 16, 17, 34, 0);
            // 
            // AddClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 253);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnUpload);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddClub";
            Text = "AddClub";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnUpload;
        private Button btnAdd;
        private Button btnClear;
        private DateTimePicker dateTimePicker1;
    }
}