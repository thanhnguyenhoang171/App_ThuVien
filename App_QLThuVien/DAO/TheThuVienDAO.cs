using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TheThuVienDAO
    {
        private static TheThuVienDAO instance;
        public static TheThuVienDAO Instance
        {

            get
            {
                if (instance == null)
                    instance = new TheThuVienDAO();
                return instance;
            }
        }

        private TheThuVienDAO() { }
        public List<TheThuVien> Xem()
        {
            List<TheThuVien> theThuViens = new List<TheThuVien>();
            string query = "SELECT * FROM The_thu_vien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maThe = item["ma_the"].ToString();
                string hoTen = item["ho_va_ten"].ToString();
                string diaChi = item["dia_chi"].ToString();
                string dienThoai = item["so_dien_thoai"].ToString() ;
                string email = item["email"].ToString();
                DateTime ngayDK = Convert.ToDateTime(item["ngay_dang_ky"]);
                DateTime ngayHH = Convert.ToDateTime(item["ngay_het_han"]);

                TheThuVien newThe = new TheThuVien(maThe, hoTen,diaChi,dienThoai, email, ngayDK, ngayHH);

                theThuViens.Add(newThe);
            }
            return theThuViens;
        }
        public bool Sua(string maThe, TheThuVien theThuVien)
        {
            string query = " UPDATE The_thu_vien SET ho_va_ten = @HoTen , dia_chi = @DiaChi , so_dien_thoai = @DienThoai , ngay_dang_ky = @NgayDK , ngay_het_han = @NgayHH where ma_the = @MaTheCu ";

            object[] para = new object[] {theThuVien.HoTen, theThuVien.DiaChi, theThuVien.DienThoai, theThuVien.NgayDK, theThuVien.NgayHH, maThe };
            if (DataProvider.Instance.ExecuteNonQuery(query, para)>0)
            {
                return true;
            }
            return false;
        }
        public bool Them(TheThuVien theThuVien)
        {
            string query = " INSERT INTO The_thu_vien ( ma_the , ho_va_ten , dia_chi , so_dien_thoai , email , ngay_dang_ky , ngay_het_han ) VALUES ( @MaThe , @HoTen , @DiaChi , @DienThoai , @Email , @NgayDK , @NgayHH )";
            object[] para = new object[] { theThuVien.MaThe, theThuVien.HoTen, theThuVien.DiaChi, theThuVien.DienThoai, theThuVien.Email, theThuVien.NgayDK, theThuVien.NgayHH};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Xoa(string maThe)
        {
            string query = " DELETE FROM The_thu_vien WHERE ma_the = @MaThe ";
            object[] para = new object[] { maThe };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
