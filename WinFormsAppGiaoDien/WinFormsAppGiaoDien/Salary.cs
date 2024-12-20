using BUS;
using ClosedXML.Excel;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Windows.Forms;
using DTO;

namespace WinFormsAppGiaoDien
{
    public partial class Salary : Form
    {
        private readonly SalaryBUS _salaryBUS;

        public Salary()
        {
            InitializeComponent();
            _salaryBUS = new SalaryBUS();
            this.Load += new System.EventHandler(this.Salary_Load);
            btnExportFile.Click += new EventHandler(this.btnExportFile_Click);
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
        }


        private void LoadSalaryData()
        {
            try
            {
                // Lấy danh sách lương chi tiết từ BUS
                var salaryDetailsList = _salaryBUS.GetSalaryDetails();

                // Đổ dữ liệu vào DataGridView
                dataGridView1.DataSource = salaryDetailsList;

                // Định dạng cột nếu cần
                dataGridView1.Columns["MonthlySalary"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Bonus"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Allowance"].DefaultCellStyle.Format = "C2";

                // Điều chỉnh chiều rộng cột
                dataGridView1.Columns["SalaryID"].Width = 100;
                dataGridView1.Columns["PlayerName"].Width = 200;
                dataGridView1.Columns["Position"].Width = 150;
                dataGridView1.Columns["ShirtNumber"].Width = 100;
                dataGridView1.Columns["Nationality"].Width = 150;
                dataGridView1.Columns["TeamName"].Width = 200;
                dataGridView1.Columns["MonthlySalary"].Width = 150;
                dataGridView1.Columns["Bonus"].Width = 150;
                dataGridView1.Columns["Allowance"].Width = 150;
                dataGridView1.Columns["SalaryDate"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Sự kiện khi form được tải
        private void Salary_Load(object sender, EventArgs e)
        {
            // Điền dữ liệu vào ComboBox PlayerID và TeamID
            cbxPlayerID.DataSource = _salaryBUS.GetPlayerList();
            cbxTeamID.DataSource = _salaryBUS.GetTeamList();
            // Đăng ký sự kiện SelectionChanged của DataGridView
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            LoadSalaryData();
        }

        // sự kiện xuất file PDF từ dữ liệu:

private void btnExportFile_Click(object sender, EventArgs e)
    {
        // Kiểm tra xem có hàng nào được chọn trong DataGridView hay không
        if (dataGridView1.SelectedRows.Count > 0)
        {
            // Lấy dòng được chọn
            var selectedRow = dataGridView1.SelectedRows[0];

            // Lấy dữ liệu từ dòng đã chọn
            var salaryID = selectedRow.Cells["SalaryID"].Value.ToString();
            var playerName = selectedRow.Cells["PlayerName"].Value.ToString();
            var position = selectedRow.Cells["Position"].Value.ToString();
            var shirtNumber = selectedRow.Cells["ShirtNumber"].Value.ToString();
            var nationality = selectedRow.Cells["Nationality"].Value.ToString();
            var teamName = selectedRow.Cells["TeamName"].Value.ToString();
            var monthlySalary = selectedRow.Cells["MonthlySalary"].Value.ToString();
            var bonus = selectedRow.Cells["Bonus"].Value.ToString();
            var allowance = selectedRow.Cells["Allowance"].Value.ToString();
            var salaryDate = selectedRow.Cells["SalaryDate"].Value.ToString();

            // Đường dẫn lưu file Excel, sử dụng tên cầu thủ để tạo tên file
            string fileName = $"{playerName}_SalaryDetails.xlsx"; // Tên cầu thủ + "_SalaryDetails"
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName); // Lưu trong thư mục Documents

            try
            {
                // Tạo workbook mới và thêm worksheet
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Salary Details");

                    // Đặt tiêu đề cho worksheet
                    worksheet.Cell(1, 1).Value = "Salary Details";
                    //worksheet.Cell(1, 1).Style.Font.SetBold().FontSize = 14;
                    worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    worksheet.Cell(1, 1).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    worksheet.Range("A1:B1").Merge();

                    // Thêm thông tin vào worksheet
                    worksheet.Cell(2, 1).Value = "Salary ID:";
                    worksheet.Cell(3, 1).Value = salaryID;
                    worksheet.Cell(2, 2).Value = "Player Name:";
                    worksheet.Cell(3, 2).Value = playerName;
                    worksheet.Cell(2, 3).Value = "Position:";
                    worksheet.Cell(3, 3).Value = position;
                    worksheet.Cell(2, 4).Value = "Shirt Number:";
                    worksheet.Cell(3, 4).Value = shirtNumber;
                    worksheet.Cell(2, 5).Value = "Nationality:";
                    worksheet.Cell(3, 5).Value = nationality;
                    worksheet.Cell(2, 6).Value = "Team Name:";
                    worksheet.Cell(3, 6).Value = teamName;
                    worksheet.Cell(2, 7).Value = "Monthly Salary:";
                    worksheet.Cell(3, 7).Value = monthlySalary;
                    worksheet.Cell(2, 8).Value = "Bonus:";
                    worksheet.Cell(3, 8).Value = bonus;
                    worksheet.Cell(2, 9).Value = "Allowance:";
                    worksheet.Cell(3, 9).Value = allowance;
                    worksheet.Cell(2, 10).Value = "Salary Date:";
                    worksheet.Cell(3, 10).Value = salaryDate;

                    // Cải thiện độ rộng cột tự động
                    worksheet.Columns().AdjustToContents();

                    // Lưu workbook vào file Excel
                    workbook.SaveAs(filePath);
                }

                MessageBox.Show($"File Excel đã được xuất thành công: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo file Excel: {ex.Message}");
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một dòng để xuất.");
        }
    }

        // Sự kiện khi người dùng chọn một hàng trong DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                var selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ các cột trong dòng và gán vào các TextBox
                //txtSalaryID.Text = selectedRow.Cells["SalaryID"].Value.ToString();
                //cbxPlayerID.SelectedItem = selectedRow.Cells["PlayerID"].Value.ToString();
                //cbxTeamID.SelectedItem = selectedRow.Cells["TeamID"].Value.ToString();
                txtMonthlySalary.Text = selectedRow.Cells["MonthlySalary"].Value.ToString();
                txtBonus.Text = selectedRow.Cells["Bonus"].Value.ToString();
                txtAllowance.Text = selectedRow.Cells["Allowance"].Value.ToString();
                dateTimePickerSalaryDate.Value = Convert.ToDateTime(selectedRow.Cells["SalaryDate"].Value);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var salary = new SalaryDTO
            {
                PlayerID = cbxPlayerID.SelectedItem.ToString(),
                TeamID = cbxTeamID.SelectedItem.ToString(),
                MonthlySalary = Convert.ToDecimal(txtMonthlySalary.Text),
                Bonus = Convert.ToDecimal(txtBonus.Text),
                Allowance = Convert.ToDecimal(txtAllowance.Text),
                SalaryDate = dateTimePickerSalaryDate.Value
            };

            _salaryBUS.AddSalary(salary);
            LoadSalaryData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var salaryID = Convert.ToInt32(selectedRow.Cells["SalaryID"].Value);

                var salary = new SalaryDTO
                {
                    SalaryID = salaryID,
                    PlayerID = cbxPlayerID.SelectedItem.ToString(),
                    TeamID = cbxTeamID.SelectedItem.ToString(),
                    MonthlySalary = Convert.ToDecimal(txtMonthlySalary.Text),
                    Bonus = Convert.ToDecimal(txtBonus.Text),
                    Allowance = Convert.ToDecimal(txtAllowance.Text),
                    SalaryDate = dateTimePickerSalaryDate.Value
                };

                _salaryBUS.UpdateSalary(salary);
                LoadSalaryData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var salaryID = Convert.ToInt32(selectedRow.Cells["SalaryID"].Value);
                _salaryBUS.DeleteSalary(salaryID);
                LoadSalaryData();
            }
        }


    }
}
