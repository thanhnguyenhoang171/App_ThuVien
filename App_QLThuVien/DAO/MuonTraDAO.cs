using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class MuonTraDAO
    {
        private static MuonTraDAO instance;
        public static MuonTraDAO Instance
        {

            get
            {
                if (instance == null)
                    instance = new MuonTraDAO();
                return instance;
            }
        }
        private MuonTraDAO() { }
        public List<MuonTra> Xem()
        {
            List<MuonTra> list_MuonTra = new List<MuonTra>();
            string query = "SELECT * FROM Muon_tra";


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maGiaoDich = item["ma_giao_dich"].ToString();
                string maSach = item["ma_sach"].ToString();
                string maThe = item["ma_the"].ToString();
                DateTime ngayMuon = Convert.ToDateTime(item["ngay_muon"]);
                DateTime ngayTra = Convert.ToDateTime(item["ngay_tra"]);
                decimal tienPhat = (decimal)item["so_tien_phat"];
                string trangThai = item["trang_thai"].ToString();

                MuonTra muonTra = new MuonTra(maGiaoDich, maSach, maThe, ngayMuon, ngayTra, tienPhat, trangThai);

                list_MuonTra.Add(muonTra);
            }

            return list_MuonTra;
        }
        public bool Sua(string maGiaoDich, MuonTra muonTra)
        {
            string query = " UPDATE Muon_tra SET ma_sach = @MaSach , ma_the = @MaThe , ngay_muon = @NgayMuon , ngay_tra = @NgayTra , so_tien_phat = @SoTienPhat , trang_thai = @TrangThai WHERE ma_giao_dich = @MaGiaoDichCu ";

            object[] para = new object[] {muonTra.MaSach, muonTra.MaThe, muonTra.NgayMuon, muonTra.NgayTra, muonTra.SoTienPhat, muonTra.TrangThai, maGiaoDich };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Them(MuonTra muonTra)
        {
            string query = " INSERT INTO Muon_tra ( ma_giao_dich , ma_sach , ma_the , ngay_muon , ngay_tra , so_tien_phat , trang_thai ) VALUES ( @MaGiaoDich , @MaSach , @MaThe , @NgayMuon , @NgayTra , @SoTienPhat , @TrangThai ) ";
            object[] para = new object[] { muonTra.MaGiaoDich, muonTra.MaSach, muonTra.MaThe, muonTra.NgayMuon, muonTra.NgayTra, muonTra.SoTienPhat, muonTra.TrangThai };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Xoa (string maGiaoDich)
        {
            string query = " DELETE FROM Muon_tra WHERE ma_giao_dich = @MaGiaoDich ";
            object[] para = new object[] { maGiaoDich };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
