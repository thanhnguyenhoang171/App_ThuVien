using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance { 
           
            get {
                if (instance == null)
                    instance = new SachDAO();
                return instance; 
            } 
        }
        private SachDAO() { }
        public List<Sach> Xem()
        {
            List <Sach> saches = new List<Sach>();
            string query = "SELECT * FROM Sach";
            ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maSach = item["ma_sach"].ToString();
                string tenSach = item["ten_sach"].ToString();
                string tacGia = item["tac_gia"].ToString();
                string theLoai = item["the_loai"].ToString();
                int soLuong = (int)item["so_luong_hien_co"];
                string moTa = item["mo_ta"].ToString();
                decimal giaSach = (decimal)item["gia"];
                int namXB = (int)item["nam_xuat_ban"];

                Sach newSach = new Sach(maSach, tenSach, tacGia, theLoai, soLuong, moTa, giaSach, namXB);

                saches.Add(newSach);
            }

            return saches;
        }
        public bool Sua(string maSach, Sach sach) {
            string query = " UPDATE Sach SET ten_sach = @TenSach , tac_gia = @TenTacGia , the_loai = @TheLoai , so_luong_hien_co = @SoLuong , mo_ta = @MoTa , gia = @GiaSach , nam_xuat_ban = @NamXB where ma_sach = @MaSachCu ";
            object[] para = new object[] {sach.TenSach, sach.TenTacGia, sach.TheLoai, sach.SoLuong, sach.MoTa, sach.GiaSach,sach.NamXB, maSach};
            if (DataProvider.Instance.ExecuteNonQuery(query, para)>0) {
                return true;    
            }
            return false;
            
        }
        public bool Xoa(string maSach)
        {
            string query = " DELETE FROM Sach WHERE ma_sach = @MaSach ";
            object[] para = new object[] { maSach };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Them(Sach sach)
        {
            string query = "INSERT INTO Sach ( ma_sach , ten_sach , tac_gia , the_loai , so_luong_hien_co , mo_ta , gia , nam_xuat_ban ) VALUES ( @MaSach , @TenSach , @TacGia , @TheLoai , @SoLuong , @MoTa , @GiaSach , @NamXB )";
            object[] para = new object[] { sach.MaSach, sach.TenSach, sach.TenTacGia, sach.TheLoai, sach.SoLuong, sach.MoTa, sach.GiaSach, sach.NamXB };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
