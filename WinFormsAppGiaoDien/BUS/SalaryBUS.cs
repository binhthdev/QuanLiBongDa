using DAL;
using DTO;

namespace BUS
{
    public class SalaryBUS
    {
        private readonly SalaryDAL _salaryDAL;

        public SalaryBUS()
        {
            _salaryDAL = new SalaryDAL();
        }

        // Lấy danh sách toàn bộ thông tin lương
        public List<SalaryDetailsDTO> GetSalaryDetails()
        {
            return _salaryDAL.GetSalaryDetails();
        }

        // Thêm thông tin lương
        public void AddSalary(SalaryDTO salary)
        {
            _salaryDAL.AddSalary(salary);
        }

        // Sửa thông tin lương
        public void UpdateSalary(SalaryDTO salary)
        {
            _salaryDAL.UpdateSalary(salary);
        }

        // Xóa thông tin lương
        public void DeleteSalary(int salaryID)
        {
            _salaryDAL.DeleteSalary(salaryID);
        }

        // Lấy danh sách Player
        public List<string> GetPlayerList()
        {
            return _salaryDAL.GetPlayerList();
        }

        // Lấy danh sách Team
        public List<string> GetTeamList()
        {
            return _salaryDAL.GetTeamList();
        }
    }
}
