using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace BUS
{
    public class TheThuVienBUS
    {
        private static TheThuVienBUS instance;
        public static TheThuVienBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new TheThuVienBUS();
                return instance;
            }
        }
        private TheThuVienBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = TheThuVienDAO.Instance.Xem();
        }
        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string maThe = row.Cells["MaThe"].Value.ToString();
            string hoTen = row.Cells["HoTen"].Value.ToString();
            string diaChi = row.Cells["DiaChi"].Value.ToString();
            string dienThoai = row.Cells["DienThoai"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            DateTime ngayDK = Convert.ToDateTime(row.Cells["NgayDK"].Value);
            DateTime ngayHH = Convert.ToDateTime(row.Cells["NgayHH"].Value);
            TheThuVien theThuVien = new TheThuVien (maThe, hoTen, diaChi, dienThoai, email, ngayDK, ngayHH);
            return TheThuVienDAO.Instance.Sua(maThe, theThuVien);
        }
        public bool Them(string maThe, string hoTen, string diaChi, string dienThoai, string email, DateTime ngayDK, DateTime ngayHH)
        {
            TheThuVien theThuVien = new TheThuVien(maThe,hoTen,diaChi,dienThoai,email,ngayDK,ngayHH);
            return TheThuVienDAO.Instance.Them(theThuVien);
        }
        public bool Xoa(DataGridView data)
        {
            if (data.SelectedCells.Count > 0)
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                string maThe = row.Cells["MaThe"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá thẻ thư viện này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (TheThuVienDAO.Instance.Xoa(maThe))
                    {
                        Xem(data);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
