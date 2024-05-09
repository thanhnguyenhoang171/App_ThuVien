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
    }
}
