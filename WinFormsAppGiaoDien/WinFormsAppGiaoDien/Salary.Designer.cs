namespace WinFormsAppGiaoDien
{
    partial class Salary
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            cbxPlayerID = new ComboBox();
            cbxTeamID = new ComboBox();
            label3 = new Label();
            dateTimePickerSalaryDate = new DateTimePicker();
            txtMonthlySalary = new TextBox();
            txtBonus = new TextBox();
            txtAllowance = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExportFile = new Button();
            dataGridView1 = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(29, 28);
            label5.Name = "label5";
            label5.Size = new Size(107, 24);
            label5.TabIndex = 18;
            label5.Text = "Player ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(29, 70);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 19;
            label1.Text = "Team ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(29, 116);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 20;
            label2.Text = "Monthly Salary :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(29, 205);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 22;
            label4.Text = "Allowance :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(29, 159);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 23;
            label6.Text = "Bonus :";
            // 
            // cbxPlayerID
            // 
            cbxPlayerID.FormattingEnabled = true;
            cbxPlayerID.Location = new Point(241, 24);
            cbxPlayerID.Name = "cbxPlayerID";
            cbxPlayerID.Size = new Size(277, 28);
            cbxPlayerID.TabIndex = 24;
            // 
            // cbxTeamID
            // 
            cbxTeamID.FormattingEnabled = true;
            cbxTeamID.Location = new Point(241, 70);
            cbxTeamID.Name = "cbxTeamID";
            cbxTeamID.Size = new Size(277, 28);
            cbxTeamID.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(29, 251);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 26;
            label3.Text = "Salary Date";
            // 
            // dateTimePickerSalaryDate
            // 
            dateTimePickerSalaryDate.Location = new Point(241, 248);
            dateTimePickerSalaryDate.Name = "dateTimePickerSalaryDate";
            dateTimePickerSalaryDate.Size = new Size(277, 27);
            dateTimePickerSalaryDate.TabIndex = 27;
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.Location = new Point(241, 113);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(277, 27);
            txtMonthlySalary.TabIndex = 28;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(241, 156);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(277, 27);
            txtBonus.TabIndex = 29;
            // 
            // txtAllowance
            // 
            txtAllowance.Location = new Point(241, 202);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.Size = new Size(277, 27);
            txtAllowance.TabIndex = 30;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(605, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 49);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(605, 91);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 49);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(605, 156);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 49);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExportFile
            // 
            btnExportFile.Location = new Point(605, 226);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.Size = new Size(140, 49);
            btnExportFile.TabIndex = 34;
            btnExportFile.Text = "Export File";
            btnExportFile.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(716, 303);
            dataGridView1.TabIndex = 35;

            //// Thêm cột vào DataGridView để hiển thị dữ liệu
            //dataGridView1.Columns.Add("SalaryID", "Salary ID");
            //dataGridView1.Columns.Add("PlayerName", "Player Name");
            //dataGridView1.Columns.Add("Position", "Position");
            //dataGridView1.Columns.Add("ShirtNumber", "Shirt Number");
            //dataGridView1.Columns.Add("Nationality", "Nationality");
            //dataGridView1.Columns.Add("TeamName", "Team Name");
            //dataGridView1.Columns.Add("MonthlySalary", "Monthly Salary");
            //dataGridView1.Columns.Add("Bonus", "Bonus");
            //dataGridView1.Columns.Add("Allowance", "Allowance");
            //dataGridView1.Columns.Add("SalaryDate", "Salary Date");

            //// Định dạng một số cột
            //dataGridView1.Columns["MonthlySalary"].DefaultCellStyle.Format = "C2"; // Hiển thị dạng tiền tệ
            //dataGridView1.Columns["Bonus"].DefaultCellStyle.Format = "C2";
            //dataGridView1.Columns["Allowance"].DefaultCellStyle.Format = "C2";

            //// Đặt chiều rộng cho các cột
            //dataGridView1.Columns["SalaryID"].Width = 100;
            //dataGridView1.Columns["PlayerName"].Width = 200;
            //dataGridView1.Columns["Position"].Width = 150;
            //dataGridView1.Columns["ShirtNumber"].Width = 100;
            //dataGridView1.Columns["Nationality"].Width = 150;
            //dataGridView1.Columns["TeamName"].Width = 200;
            //dataGridView1.Columns["MonthlySalary"].Width = 150;
            //dataGridView1.Columns["Bonus"].Width = 150;
            //dataGridView1.Columns["Allowance"].Width = 150;
            //dataGridView1.Columns["SalaryDate"].Width = 150;

            // Thiết lập để tự động điều chỉnh chiều cao dòng
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 653);
            Controls.Add(dataGridView1);
            Controls.Add(btnExportFile);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtAllowance);
            Controls.Add(txtBonus);
            Controls.Add(txtMonthlySalary);
            Controls.Add(dateTimePickerSalaryDate);
            Controls.Add(label3);
            Controls.Add(cbxTeamID);
            Controls.Add(cbxPlayerID);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Salary";
            Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private ComboBox cbxPlayerID;
        private ComboBox cbxTeamID;
        private Label label3;
        private DateTimePicker dateTimePickerSalaryDate;
        private TextBox txtMonthlySalary;
        private TextBox txtBonus;
        private TextBox txtAllowance;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExportFile;
        private DataGridView dataGridView1;

    }
}