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
    }
}
