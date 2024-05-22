using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable ChuyenListSangDGV(List<TheThuVien> theThuVien)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_the", typeof(string));
            dt.Columns.Add("ho_va_ten", typeof(string));
            dt.Columns.Add("dia_chi", typeof(string));
            dt.Columns.Add("so_dien_thoai", typeof(string));
            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("ngay_dang_ky", typeof(DateTime));
            dt.Columns.Add("ngay_het_han", typeof(DateTime));


            foreach (var the in theThuVien)
            {
                dt.Rows.Add(the.MaThe, the.HoTen, the.DiaChi, the.DienThoai, the.Email, the.NgayDK, the.NgayHH);
            }
            return dt;
        }
        public void Xem(DataGridView data)
        {
            List<TheThuVien> the = TheThuVienDAO.Instance.Xem();

            DataTable dt = ChuyenListSangDGV(the);

            data.DataSource = dt;

            data.Columns["ma_the"].HeaderText = "Mã Thẻ";
            data.Columns["ho_va_ten"].HeaderText = "Họ Tên";
            data.Columns["dia_chi"].HeaderText = "Địa Chỉ";
            data.Columns["so_dien_thoai"].HeaderText = "Số Điện Thoại";
            data.Columns["email"].HeaderText = "Email";
            data.Columns["ngay_dang_ky"].HeaderText = "Ngày Đăng Ký";
            data.Columns["ngay_het_han"].HeaderText = "Ngày Hết Hạn";
        
            // data.DataSource = TheThuVienDAO.Instance.Xem();
        }
        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;




            string maThe = row.Cells[0].Value.ToString();
            string hoTen = row.Cells[1].Value.ToString();
            string diaChi = row.Cells[2].Value.ToString();
            string dienThoai = row.Cells[3].Value.ToString();
            string email = row.Cells[4].Value.ToString();
            DateTime ngayDK = Convert.ToDateTime(row.Cells[5].Value);
            DateTime ngayHH = Convert.ToDateTime(row.Cells[6].Value);
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
                string maThe = row.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá Thẻ Thư Viện này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
